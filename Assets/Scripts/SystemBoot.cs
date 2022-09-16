using UnityEngine;

public class SystemBoot : MonoBehaviour
{
    [SerializeField]
    private DataStorage dataStorage;

    private SpawnSystem spawnSystem;
    private UISystem uiSystem;
    
    private void Start()
    {
        spawnSystem = new SpawnSystem(new VoxelModelFactory(), dataStorage);
        spawnSystem.StartSpawn();
        uiSystem = new UISystem(dataStorage);
        uiSystem.LoadUISystem();
    }
}
