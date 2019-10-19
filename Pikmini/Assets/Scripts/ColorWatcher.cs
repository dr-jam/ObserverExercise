using System;
using UnityEngine;

public class ColorWatcher :  IWatcher
{
    private Color Value;
    private Color PolledValue;
    private Func<Color> GetColorValue;
    private Action<Color> CallBack;
    
    public ColorWatcher(Func<Color> getColorValue, Action<Color> callback )
    {
        this.GetColorValue = getColorValue;
        this.CallBack = callback;
        Watch();
    }
    public void Watch ()
    {
        //Poll for a potential update to the color.
        //If the polled value is different than Value:
        //-update via CallBack
        //-store the updated value as Value
    }
}