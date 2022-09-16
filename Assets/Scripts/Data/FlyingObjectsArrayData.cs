using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Data/Flying Objects Array")]
public class FlyingObjectsArrayData : ScriptableObject
{
    [Header("Список объектов")]
    [SerializeField]
    private FlyingObjectsData[] flyingObjectsDataset;

    public FlyingObjectsData[] FlyingObjectDataset => flyingObjectsDataset;
}
