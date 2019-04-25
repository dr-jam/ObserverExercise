using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Pikmini;

public class ButtonManager : MonoBehaviour
{
    [SerializeField]
    private Text colorText0, colorText1, colorText2;
    [SerializeField]
    private GameObject dest1, dest2, dest3;
    [SerializeField]
    private GameObject scriptHomeObj;
    [SerializeField]
    private ColorBind colorbindings;

    private PublisherManager PublisherManager;
    private Color color;
    private Vector3 Destination;
    private int ColorID = -1;

    private void Start ()
    {
        PublisherManager = scriptHomeObj.GetComponent<PublisherManager>();
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
        this.Destination = dest1.transform.position;
    }
    public void Dest2()
    {
        this.Destination = dest2.transform.position;
    }
    public void Dest3()
    {
        this.Destination = dest3.transform.position;
    }
    public void Send()
    {
        if (null != this.Destination && -1 != this.ColorID)
        {
            PublisherManager.SendMessageWithPublisher(this.ColorID, this.Destination);
        }
    }
}