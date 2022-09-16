using UnityEngine;

public class VoxelModelFactory : IFlyingObjectsFactory
{
    private GameObject attractionObject;
    private DataStorage dataStorage;

    public void CreateFlyingObjects(DataStorage data)
    {
        dataStorage = data;
        var counter = new Counter(dataStorage, dataStorage.NameDatabase.CollisionCounterName);
        var objectsDataset = data.FlyingObjectsData.FlyingObjectDataset;

        for (int i = 0; i < objectsDataset.Length; i++)
        {
            var generatedModel = GenerateVoxelModel(objectsDataset[i]);
            CreateMVC(generatedModel, objectsDataset[i], counter);
        }
    }

    private GameObject GenerateVoxelModel(FlyingObjectsData data)
    {
        var model = GameObject.Instantiate(data.RootPrefabRb.gameObject, data.SpawnPosition, Quaternion.identity);
        var parentTransform = model.transform;
        var componentPrefab = data.ComponentPrefab;
        var width = data.Width;
        var height = data.Height;
        var deep = data.Deep;

        for (int z = 0; z < deep; z++)
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    var occupancy = Random.Range(0, 3);
                    if (occupancy == 1)
                    {
                        var instance = GameObject.Instantiate(componentPrefab, parentTransform);
                        instance.transform.localPosition = new Vector3(x, y, z);
                    }
                }
            }
        }
        return model;
    }

    private void CreateMVC(GameObject generatedModel, FlyingObjectsData data, IInitializable<ITicker> counter)
    {
        if (!attractionObject || attractionObject.transform.position != data.AttractionObject.transform.position)
            attractionObject = GameObject.Instantiate(data.AttractionObject);

        var modelRb = generatedModel.GetComponent<Rigidbody>();
        var objectModel = new FlyingObjectModel(modelRb, attractionObject, data.GravityPower, data.HitPower, counter);
        var objectView = generatedModel.GetComponent<IFlyingObjectView>();
        var objectController = new FlyingObjectController(objectView, objectModel);
    }
}
