using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Pikmini;

public class ButtonManager : MonoBehaviour
{
    [SerializeField]
    private Text ColorText0, ColorText1, ColorText2;
    [SerializeField]
    private GameObject Destination1, Destination2, Destination3;
    [SerializeField]
    private GameObject ScriptHome;
    [SerializeField]
    private ColorBind ColorBindings;

    private PublisherManager PublisherManager;
    private Color color;
    private Vector3 Destination;
    private int ColorID = -1;

    private void Start ()
    {
        PublisherManager = ScriptHome.GetComponent<PublisherManager>();
    }
    public void Color0()
    {
        ColorID = 1;
    }
    public void Color1()
    {
        ColorID = 2;
    }
    public void Color2()
    {
        ColorID = 3;
    }
    public void Dest1()
    {
        this.Destination = Destination1.transform.position;
    }
    public void Dest2()
    {
        this.Destination = Destination2.transform.position;
    }
    public void Dest3()
    {
        this.Destination = Destination3.transform.position;
    }
    public void Send()
    {
        if (-1 != this.ColorID)
        {
            PublisherManager.SendMessageWithPublisher(this.ColorID, this.Destination);
            FindObjectOfType<SoundManager>().PlaySoundEffect("Menu");
        }
    }

    public void Update()
    {
        this.ColorText0.color = this.ColorBindings.GetGroup1Color();
        this.ColorText1.color = this.ColorBindings.GetGroup2Color();
        this.ColorText2.color = this.ColorBindings.GetGroup3Color();
    }
}