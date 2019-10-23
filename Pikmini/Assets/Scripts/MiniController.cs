
using UnityEngine;
using UnityEngine.AI;

public class MiniController : MonoBehaviour
{
    [SerializeField]
    private NavMeshAgent Agent;
    [SerializeField]
    private ColorBind ColorBindings;
    private ColorWatcher Watcher;
    private PublisherManager PublisherManager;
    private float Throttle;
    private int GroupID = 1;
    
    void Awake()
    {
        this.PublisherManager = GameObject.FindGameObjectWithTag("Script Home").GetComponent<PublisherManager>();
        this.RandomizeBody();
        this.GroupID = Random.Range(1, 4);
        this.PublisherManager.SubscribeToGroup(GroupID, OnMoveMessage);
        switch(this.GroupID)
        {
            case 1:
                this.ChangeColor(this.ColorBindings.GetGroup1Color());
                //set up a watcher for Stage 1.1
                break;
            case 2:
                this.ChangeColor(this.ColorBindings.GetGroup2Color());
                //set up a watcher for Stage 1.1
                break;
            case 3:
                this.ChangeColor(this.ColorBindings.GetGroup3Color());
                //set up a watcher for Stage 1.1
                break;
            default:
                Debug.Log("MiniController is Awake but has no group.");
                break;
        }
    }

    void OnMouseDown()
    {
        this.PublisherManager.UnsubscribeFromGroup(GroupID, OnMoveMessage);
        this.GroupID = (this.GroupID % this.PublisherManager.GroupCount) + 1;
        this.PublisherManager.SubscribeToGroup(GroupID, OnMoveMessage);
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
        Agent.SetDestination(destination);
    }
}
