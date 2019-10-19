using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ColorBind : ScriptableObject
{
    //color palette is Giant Goldfish by manekineko
    //https://www.colourlovers.com/palette/92095/Giant_Goldfish
    [SerializeField]
    private Color Group1Color = new Color(0.412f, 0.824f, 0.906f); //aoi
    [SerializeField]
    private Color Group2Color = new Color(0.878f, 0.894f, 0.80f); //beach storm
    [SerializeField]
    private Color Group3Color = new Color(0.98f, 0.412f, 0.0f); //unreal food pills

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
