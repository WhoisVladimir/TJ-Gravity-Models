using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class CounterTextHandler 
{
    protected ITicker ticker;
    protected DataStorage dataStorage;
    protected GameObject uiObject;
    protected Button resetButton;

    protected StringBuilder stringBuilder;
    protected int textLength;
    protected TMP_Text itemText;
    protected int dynamicComponent;

    public CounterTextHandler(DataStorage dataStorage, GameObject uiObject, string staticText, Button resetButton)
    {
        this.dataStorage = dataStorage;
        this.uiObject = uiObject;
        this.resetButton = resetButton;

        stringBuilder = new StringBuilder(staticText);
        textLength = stringBuilder.Length;
        itemText= uiObject.GetComponent<TMP_Text>();
        dynamicComponent = 0;
        resetButton.onClick.AddListener(ResetCounter);
    }

    public abstract void StartHandle();

    protected virtual void OnDynamicComponentUpdate()
    {
        stringBuilder.Remove(textLength, stringBuilder.Length - textLength);
        stringBuilder.Append(dynamicComponent++);

        itemText.text = stringBuilder.ToString();
    }

    protected virtual void ResetCounter()
    {
        dynamicComponent = 0;
        OnDynamicComponentUpdate();
    }

}
