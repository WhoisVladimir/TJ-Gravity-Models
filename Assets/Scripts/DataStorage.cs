using System.Collections.Generic;
using UnityEngine;

public class DataStorage : MonoBehaviour
{
    [Header("������ ������ ��������")]
    [SerializeField] private FlyingObjectsArrayData flyingObjectsData;

    [Header("���� ���")]
    [SerializeField] private NameDatabase nameDatabase;

    [Header("UI ����������")]
    [SerializeField] private UIComponentsData uiDatabase;

    [Header("UI �����")]
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
