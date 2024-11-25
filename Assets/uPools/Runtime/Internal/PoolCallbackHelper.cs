using System.Collections.Generic;
using UnityEngine;

namespace uPools
{
    internal static class PoolCallbackHelper
    {
        static readonly List<IPoolCallbackReceiver> componentsBuffer = new();

        public static void InvokeOnRent(GameObject obj)
        {
            obj.GetComponentsInChildren(componentsBuffer);
            var componentsToInvoke = new List<IPoolCallbackReceiver>(componentsBuffer);

            foreach (var receiver in componentsToInvoke)
            {
                receiver.OnRent();
            }
        }

        public static void InvokeOnReturn(GameObject obj)
        {
            obj.GetComponentsInChildren(componentsBuffer);
            var componentsToInvoke = new List<IPoolCallbackReceiver>(componentsBuffer);

            foreach (var receiver in componentsToInvoke)
            {
                receiver.OnReturn();
            }
        }
    }
}
