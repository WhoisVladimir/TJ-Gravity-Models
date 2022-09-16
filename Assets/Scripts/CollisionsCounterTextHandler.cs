using UnityEngine;
using UnityEngine.UI;

public class CollisionsCounterTextHandler : CounterTextHandler
{
    public CollisionsCounterTextHandler(DataStorage dataStorage, GameObject uiElement, string staticText, Button resetButton) 
        : base(dataStorage,uiElement, staticText, resetButton)
    {
    }
    
    ~CollisionsCounterTextHandler()
    {
        ticker.Tick -= OnDynamicComponentUpdate;
    }

    public override void StartHandle()
    {
        var collisionCounterName = dataStorage.NameDatabase.CollisionCounterName.GetHashCode();
        if (dataStorage.Tickers.TryGetValue(collisionCounterName, out var counter))
        {
            ticker = counter;
            ticker.Tick += OnDynamicComponentUpdate;
            OnDynamicComponentUpdate();
        }
    }
}
