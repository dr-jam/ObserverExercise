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

    }
}