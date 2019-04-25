using System;
using UnityEngine;
using Pikmini;
// change name to Publisher Manager
public class PublisherManager : MonoBehaviour
{
    
    public int GroupCount { get; } = 3;
    private IPublisher Group1Publisher;
    private IPublisher Group2Publisher;
    private IPublisher Group3Publisher;

    public void SendMessageWithPublisher(int group, Vector3 destination)
    {
    }
    public void Register(int group, Action<Vector3> callback)
    {
    }
    public void Unregister(int group, Action<Vector3> callback)
    {
    }
}
