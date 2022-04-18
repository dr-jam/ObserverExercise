
using UnityEngine;
using UnityEngine.AI;

public class MiniController : MonoBehaviour
{
    [SerializeField]
    private NavMeshAgent agent;
    [SerializeField]
    private ColorBind colorBindings;
    private ColorWatcher watcher;
    private PublisherManager publisherManager;
    private float throttle;
    private int groupID = 1;
    
    void Awake()
    {
        this.publisherManager = GameObject.FindGameObjectWithTag("Script Home").GetComponent<PublisherManager>();
        this.RandomizeBody();
        this.groupID = Random.Range(1, 4);
        this.publisherManager.SubscribeToGroup(groupID, OnMoveMessage);
        switch(this.groupID)
        {
            case 1:
                this.ChangeColor(this.colorBindings.GetGroup1Color());
                //set up a watcher for Stage 1.1
                break;
            case 2:
                this.ChangeColor(this.colorBindings.GetGroup2Color());
                //set up a watcher for Stage 1.1
                break;
            case 3:
                this.ChangeColor(this.colorBindings.GetGroup3Color());
                //set up a watcher for Stage 1.1
                break;
            default:
                Debug.Log("MiniController is Awake but has no group.");
                break;
        }
    }

    /// <summary>
    /// Updates the color of the object.
    /// </summary>
    /// <param name="color">The Renderer's material property will be updated
    /// with this color parameter.</param>
    private void ChangeColor(Color color)
    {
        foreach (Transform child in transform)
        {
            child.GetComponent<Renderer>().material.SetColor("MainColor", color);
        }
    }

    private void RandomizeBody()
    {
        var randomScale = Random.Range(0.1f, 1.0f);
        this.gameObject.transform.localScale *= randomScale;
    }

    public void OnMoveMessage(Vector3 destination)
    {
        agent.SetDestination(destination);
    }
}
