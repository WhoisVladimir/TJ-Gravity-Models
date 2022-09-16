using System;
using UnityEngine;

public class FlyingObjectView : MonoBehaviour, IFlyingObjectView
{
    public event Action PhysicsUpdate;
    public event Action<Collision> ModelCollision;
    public event Action<Collider> ModelTrigger;
    public event Action ModelDestroy;

    private void FixedUpdate()
    {
        PhysicsUpdate?.Invoke();
    }

    private void OnCollisionEnter(Collision collision)
    {
        ModelCollision?.Invoke(collision);
    }

    private void OnTriggerEnter(Collider other)
    {
        ModelTrigger?.Invoke(other);
    }

    private void OnDestroy()
    {
        ModelDestroy?.Invoke();
    }
}
