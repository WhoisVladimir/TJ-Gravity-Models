public class SpawnSystem
{
    private IFlyingObjectsFactory factory;
    private DataStorage data;

    public SpawnSystem(IFlyingObjectsFactory objectsFactory, DataStorage dataStorage)
    {
        factory = objectsFactory;
        data = dataStorage;
    }

    public void StartSpawn()
    {
        factory.CreateFlyingObjects(data);
    }
}
