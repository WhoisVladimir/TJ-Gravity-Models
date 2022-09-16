using UnityEngine;

[CreateAssetMenu(fileName = "UIDatabase", menuName = "Data/UIDatabase")]
public class UIComponentsData : ScriptableObject
{
    [Header("�������� ������")]
    [SerializeField] private GameObject rootCanvas;

    [Header("���������� ������")]
    [SerializeField] private GameObject dynamicCanvas;

    [Header("������� ������������")]
    [SerializeField] private GameObject collisionCounterUI;

    [Header("������")]
    [SerializeField] private GameObject timeCounterUI;

    [Header("������ ������ ���������")]
    [SerializeField] private GameObject resetCountersButton;

    public GameObject RootCanvas => rootCanvas;
    public GameObject DynamicCanvas => dynamicCanvas;
    public GameObject CollisionCounterUI => collisionCounterUI;
    public GameObject TimeCounterUI => timeCounterUI;
    public GameObject ResetCountersButton => resetCountersButton;
}
