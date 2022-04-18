using System;
using UnityEngine;
using Pikmini;
// change name to Publisher Manager
public class PublisherManager : MonoBehaviour
{
    
    public int groupCount { get; } = 3;
    private IPublisher group1Publisher;
    private IPublisher group2Publisher;
    private IPublisher group3Publisher;

    /// <summary>
    /// Sends the the destination to all of the subscribers of a particular
    /// publisher based on group id.
    /// </summary>
    /// <param name="group">The group id of the publisher to activate.</param>
    /// <param name="destination">The destination to be sent.</param>
    public void SendMessageWithPublisher(int group, Vector3 destination)
    {
    }

    /// <summary>
    /// Subscribes to a publisher based on group id. The callback is executed
    /// when the publisher of the group sends a message.
    /// </summary>
    /// <param name="group">The group id.</param>
    /// <param name="callback">The callback to call when a message is sent.
    /// </param>
    public void SubscribeToGroup(int group, Action<Vector3> callback)
    {
    }

    /// <summary>
    /// Unsubscribes a callback from a group publiser.
    /// </summary>
    /// <param name="group">The group id.</param>
    /// <param name="callback">The callback to remove from the subscriber list.
    /// </param>
    public void UnsubscribeFromGroup(int group, Action<Vector3> callback)
    {
    }
}
