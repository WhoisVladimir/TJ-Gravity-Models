using UnityEngine;

[CreateAssetMenu(fileName = "UITextdatabase", menuName = "Data/UIText")]
public class UITextDatabase : ScriptableObject
{
    [Header("����� �������")]
    [SerializeField] private string timerText;

    [Header("����� �������� ������������")]
    [SerializeField] private string collisionCounterText;

    public string TimerText => timerText;
    public string CollisionCounterText => collisionCounterText;
}
