using System;
using UnityEngine;

namespace Pikmini
{
    public interface IPublisher
    {
        void Unregister(Action<Vector3> notifier);

        void Register(Action<Vector3> notifier);

        void Notify(Vector3 transform);
    }
}