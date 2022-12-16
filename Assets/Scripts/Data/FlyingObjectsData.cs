using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Data/Flying Object")]
public class FlyingObjectsData : ScriptableObject
{
    [Header("Корневой объект, содержащий Rigidbody")]
    [SerializeField] private Rigidbody rootRigidBody;

    [Header("Префаб части модели, содержащий коллайдер")]
    [SerializeField] private Collider componentPrefab;

    [Header("Объект притяжения")]
    [SerializeField] private GameObject attractionObject;

    [Header("Параметры модели")]
    [SerializeField] private int width, height, deep;

    [Header("Точка спавна")] 
    [SerializeField] private Vector3 spawnPosition;

    [Header("Сила притяжения")]
    [SerializeField] private float gravityPower;

    [Header("Сила удара")]
    [SerializeField] private float hitPower;

    [Header("Цвет коллизии")]
    [SerializeField] private Material collisionIndicator;

    public Rigidbody RootPrefabRb => rootRigidBody;
    public GameObject ComponentPrefab => componentPrefab.gameObject;
    public GameObject AttractionObject => attractionObject;
    public int Width => width;
    public int Height => height;
    public int Deep => deep;
    public Vector3 SpawnPosition => spawnPosition;
    public float GravityPower => gravityPower;
    public float HitPower => hitPower;

    public Material CollisionIndicator => collisionIndicator;
}
