using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Data/Flying Object")]
public class FlyingObjectsData : ScriptableObject
{
    [Header("�������� ������, ���������� Rigidbody")]
    [SerializeField] private Rigidbody rootRigidBody;

    [Header("������ ����� ������, ���������� ���������")]
    [SerializeField] private Collider componentPrefab;

    [Header("������ ����������")]
    [SerializeField] private GameObject attractionObject;

    [Header("��������� ������")]
    [SerializeField] private int width, height, deep;

    [Header("����� ������")] 
    [SerializeField] private Vector3 spawnPosition;

    [Header("���� ����������")]
    [SerializeField] private float gravityPower;

    [Header("���� �����")]
    [SerializeField] private float hitPower;

    [Header("���� ��������")]
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
