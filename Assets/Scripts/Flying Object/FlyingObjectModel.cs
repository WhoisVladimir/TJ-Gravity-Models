using UnityEngine;
using System.Threading;

public class FlyingObjectModel : IFlyingObjectModel
{
    public Rigidbody RB { get; private set; }
    public GameObject GravityTarget { get; private set; }
    public float GravityPower { get; private set; } 
    public float ImpulsePower {get; private set;}
    public CancellationTokenSource CancellationByDestroyed { get; private set; }
    public IInitializable<ITicker> Counter { get; private set; }
    public Material CollisionIndicator { get; private set; }
    
    public bool IsStoped { get; set; }
    public bool IsFirstCollision { get; set; }

    public FlyingObjectModel(Rigidbody rb, GameObject target, float gravityPower, float impulsePower, IInitializable<ITicker> counter,
        Material collisionMaterial)
    {
        RB = rb;
        GravityTarget = target;
        GravityPower = gravityPower;
        ImpulsePower = impulsePower;
        Counter = counter;
        CollisionIndicator = collisionMaterial;

        CancellationByDestroyed = new CancellationTokenSource();
        RB.useGravity = false;
        IsStoped = false;
        IsFirstCollision = true;
    }
}
