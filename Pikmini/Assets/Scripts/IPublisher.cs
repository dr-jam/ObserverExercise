using System;
using UnityEngine;

namespace Pikmini
{
    public interface IPublisher
    {
        void Unsubscribe(Action<Vector3> notifier);

        void Subscribe(Action<Vector3> notifier);

        void Notify(Vector3 transform);
    }
}
