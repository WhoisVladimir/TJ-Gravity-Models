using UnityEngine;

[CreateAssetMenu(fileName = "UIDatabase", menuName = "Data/UIDatabase")]
public class UIComponentsData : ScriptableObject
{
    [Header("Корневой канвас")]
    [SerializeField] private GameObject rootCanvas;

    [Header("Динамичный канвас")]
    [SerializeField] private GameObject dynamicCanvas;

    [Header("Счётчик столкновений")]
    [SerializeField] private GameObject collisionCounterUI;

    [Header("Таймер")]
    [SerializeField] private GameObject timeCounterUI;

    [Header("Кнопка сброса счётчиков")]
    [SerializeField] private GameObject resetCountersButton;

    public GameObject RootCanvas => rootCanvas;
    public GameObject DynamicCanvas => dynamicCanvas;
    public GameObject CollisionCounterUI => collisionCounterUI;
    public GameObject TimeCounterUI => timeCounterUI;
    public GameObject ResetCountersButton => resetCountersButton;
}
