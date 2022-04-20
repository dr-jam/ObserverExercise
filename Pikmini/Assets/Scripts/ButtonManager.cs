using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Pikmini;

public class ButtonManager : MonoBehaviour
{
    [SerializeField]
    private Text colorText0, colorText1, colorText2;
    [SerializeField]
    private GameObject destination1, destination2, destination3;
    [SerializeField]
    private GameObject scriptHome;
    [SerializeField]
    private ColorBind colorBindings;

    private PublisherManager pcublisherManager;
    private Color color;
    private Vector3 destination;
    private int colorID = -1;

    private void Start ()
    {
        pcublisherManager = scriptHome.GetComponent<PublisherManager>();
    }
    public void Color0()
    {
        colorID = 1;
    }
    public void Color1()
    {
        colorID = 2;
    }
    public void Color2()
    {
        colorID = 3;
    }
    public void Dest1()
    {
        this.destination = destination1.transform.position;
    }
    public void Dest2()
    {
        this.destination = destination2.transform.position;
    }
    public void Dest3()
    {
        this.destination = destination3.transform.position;
    }
    public void Send()
    {
        if (-1 != this.colorID)
        {
            pcublisherManager.SendMessageWithPublisher(this.colorID, this.destination);
            FindObjectOfType<SoundManager>().PlaySoundEffect("SendMessage");
        }
    }

    public void Update()
    {
        this.colorText0.color = this.colorBindings.GetGroup1Color();
        this.colorText1.color = this.colorBindings.GetGroup2Color();
        this.colorText2.color = this.colorBindings.GetGroup3Color();
    }
}