using UnityEngine;

[CreateAssetMenu(fileName = "UITextdatabase", menuName = "Data/UIText")]
public class UITextDatabase : ScriptableObject
{
    [Header("Текст таймера")]
    [SerializeField] private string timerText;

    [Header("Текст счётчика столкновений")]
    [SerializeField] private string collisionCounterText;

    public string TimerText => timerText;
    public string CollisionCounterText => collisionCounterText;
}
