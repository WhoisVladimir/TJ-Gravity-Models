using System;
using System.Threading.Tasks;
using UnityEngine;

public class FlyingObjectController : ITicker
{
    private IFlyingObjectView view;
    private IFlyingObjectModel model;
    
    public event Action Tick;

    public FlyingObjectController(IFlyingObjectView view, IFlyingObjectModel model)
    {
        this.view = view;
        this.model = model;

        view.PhysicsUpdate += OnPhysicsUpdate;
        view.ModelCollision += OnModelCollision;
        view.ModelTrigger += OnModelTrigger;
        view.ModelDestroy += OnModelDestroy;

        model.Counter.InitializeCounter(this);
    }

    private void OnPhysicsUpdate()
    {
        AdjustGravityDirection();
    }

    private void OnModelTrigger(Collider collider)
    {
        StopRigidBody(collider);
    }

    private void OnModelCollision(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<IFlyingObjectView>(out var anotherFlyingObject))
        {
            Tick?.Invoke();
            MarkMoving();
            HitEnemyObject(collision);
            ColorizeModelPart(collision);
        }
    }
    private void OnModelDestroy()
    {
        model.CancellationByDestroyed.Cancel();
        view.PhysicsUpdate -= OnPhysicsUpdate;
        view.ModelCollision -= OnModelCollision;
        view.ModelTrigger -= OnModelTrigger;
        view.ModelDestroy -= OnModelDestroy;
    }

    private void AdjustGravityDirection()
    {
        var targetPosition = model.GravityTarget.transform.position;
        var objectPosition = model.RB.position;
        var gravityDirection = (targetPosition - objectPosition).normalized;

        model.RB.AddForce(gravityDirection * model.GravityPower);
    }

    private async void MarkMoving()
    {
        if (model.IsStoped)
        {
            if (model.IsFirstCollision)
            {
                await Task.Delay(100, model.CancellationByDestroyed.Token);

                model.IsFirstCollision = true;
                model.IsStoped = false;
            }
        }
    }

    private async void HitEnemyObject(Collision collision)
    {
        if (model.IsFirstCollision)
        {
            var reboundDirection = (collision.rigidbody.position - model.RB.position).normalized;
            collision.rigidbody.AddForce(reboundDirection * model.ImpulsePower, ForceMode.Impulse);

            model.IsFirstCollision = false;
            var cancellationToken = model.CancellationByDestroyed.Token;
            await Task.Delay(100, cancellationToken);
            model.IsFirstCollision = true;
        }
    }
    private void ColorizeModelPart(Collision collision)
    {
        var ownCollider = collision.contacts[0].thisCollider;
        var renderer = ownCollider.GetComponent<Renderer>();
        if (renderer && renderer.material.color == Color.white)
        {
            renderer.material = new Material(renderer.material);
            renderer.material.color = Color.red;
        }
    }

    private void StopRigidBody(Collider other)
    {
        if (!other.gameObject.Equals(model.GravityTarget.gameObject))
            return;

        if (!model.IsStoped)
        {
            model.RB.velocity = Vector3.zero;
            model.IsStoped = true;
        }
    }
}
