using UnityEngine;

[CreateAssetMenu(fileName = "NamesDatabase", menuName = "Data/Names Database")]
public class NameDatabase : ScriptableObject
{
    [Header("��� �������� ������������")]
    [SerializeField] private string collisionCounterName;

    public string CollisionCounterName => collisionCounterName;
}
