using System.Threading;
using UnityEngine;

public interface IFlyingObjectModel
{
    public Rigidbody RB { get; }
    public GameObject GravityTarget { get; }
    public float GravityPower { get; }
    public float ImpulsePower { get; }
    public CancellationTokenSource CancellationByDestroyed { get; }
    public IInitializable<ITicker> Counter { get; }

    public bool IsStoped { get; set; }
    public bool IsFirstCollision { get; set; }
}
