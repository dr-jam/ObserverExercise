using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ColorBind : ScriptableObject
{
    [SerializeField]
    private Color Group1Color = Color.red;
    [SerializeField]
    private Color Group2Color = Color.green;
    [SerializeField]
    private Color Group3Color = Color.blue;

    public Color GetGroup1Color()
    {
        return this.Group1Color;
    }

    public Color GetGroup2Color()
    {
        return this.Group2Color;
    }

    public Color GetGroup3Color()
    {
        return this.Group3Color;
    }
}
