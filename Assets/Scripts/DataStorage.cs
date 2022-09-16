using System.Collections.Generic;
using UnityEngine;

public class DataStorage : MonoBehaviour
{
    [Header("Массив данных объектов")]
    [SerializeField] private FlyingObjectsArrayData flyingObjectsData;

    [Header("База имён")]
    [SerializeField] private NameDatabase nameDatabase;

    [Header("UI компоненты")]
    [SerializeField] private UIComponentsData uiDatabase;

    [Header("UI текст")]
    [SerializeField] private UITextDatabase uiTextDatabase;
    
    public FlyingObjectsArrayData FlyingObjectsData => flyingObjectsData;
    public NameDatabase NameDatabase => nameDatabase;
    public UIComponentsData UIDatabase => uiDatabase;
    public UITextDatabase UITextDatabase => uiTextDatabase;

    public Dictionary<int, ITicker> Tickers { get; private set; }

    private void Awake()
    {
        Tickers = new Dictionary<int, ITicker>();
    }
}
