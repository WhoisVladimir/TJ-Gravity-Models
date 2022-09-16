using System;
using UnityEngine;
public interface IFlyingObjectView
{
    event Action PhysicsUpdate;
    event Action<Collision> ModelCollision;
    event Action<Collider> ModelTrigger;
    event Action ModelDestroy;
}
