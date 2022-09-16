using UnityEngine;
using UnityEngine.UI;

public class TimerTextHandler : CounterTextHandler
{
    public TimerTextHandler(DataStorage dataStorage, GameObject uiElement, string staticText, Button resetButton) 
        : base(dataStorage, uiElement, staticText, resetButton) 
    { }

    ~TimerTextHandler()
    {
        ticker.Tick -= OnDynamicComponentUpdate;
    }

    public override void StartHandle()
    {
        var timer = new Timer(1000);
        ticker = timer;
        ticker.Tick += OnDynamicComponentUpdate;
        OnDynamicComponentUpdate();
        timer.StartTimer();
    }
}
