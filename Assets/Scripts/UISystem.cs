using UnityEngine;
using UnityEngine.UI;

public class UISystem
{
    private DataStorage dataStorage;

    public UISystem(DataStorage dataStorage)
    {
        this.dataStorage = dataStorage;
    }

    public void LoadUISystem()
    {
        var rootCanvas = GameObject.Instantiate(dataStorage.UIDatabase.RootCanvas);
        var resetButtonObj = GameObject.Instantiate(dataStorage.UIDatabase.ResetCountersButton, rootCanvas.transform);
        var dynamicCanvas = GameObject.Instantiate(dataStorage.UIDatabase.DynamicCanvas, rootCanvas.transform);
        var secondsCounter = GameObject.Instantiate(dataStorage.UIDatabase.TimeCounterUI, dynamicCanvas.transform);
        var collisionsCounter = GameObject.Instantiate(dataStorage.UIDatabase.CollisionCounterUI, dynamicCanvas.transform);

        var resetButton = resetButtonObj.GetComponentInChildren<Button>();
        var timeCounterHandler = new TimerTextHandler(dataStorage, secondsCounter, 
            dataStorage.UITextDatabase.TimerText, resetButton);
        var collisionsCounterHandler = new CollisionsCounterTextHandler(dataStorage, collisionsCounter,
            dataStorage.UITextDatabase.CollisionCounterText, resetButton);

        timeCounterHandler.StartHandle();
        collisionsCounterHandler.StartHandle();
    }

}
