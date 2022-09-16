using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Data/Flying Objects Array")]
public class FlyingObjectsArrayData : ScriptableObject
{
    [Header("������ ��������")]
    [SerializeField]
    private FlyingObjectsData[] flyingObjectsDataset;

    public FlyingObjectsData[] FlyingObjectDataset => flyingObjectsDataset;
}
