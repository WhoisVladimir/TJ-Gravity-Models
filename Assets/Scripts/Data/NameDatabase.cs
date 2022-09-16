using UnityEngine;

[CreateAssetMenu(fileName = "NamesDatabase", menuName = "Data/Names Database")]
public class NameDatabase : ScriptableObject
{
    [Header("Имя счётчика столкновений")]
    [SerializeField] private string collisionCounterName;

    public string CollisionCounterName => collisionCounterName;
}
