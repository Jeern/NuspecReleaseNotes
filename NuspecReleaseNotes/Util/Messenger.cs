using System;
using System.Collections.Generic;

namespace NuspecReleaseNotes.Util
{
    public static class Messenger
    {
        private static readonly Dictionary<string, List<object>> RegisteredActions = new Dictionary<string, List<object>>();

        public static void Register<T>(MessageNames messageName, Action<T> action)
        {
            Register(GetKey<T>(messageName), action);
        }

        private static void Register<T>(string key, Action<T> action)
        {
            if (!RegisteredActions.ContainsKey(key))
            {
                RegisteredActions.Add(key, new List<object>());
            }
            RegisteredActions[key].Add(action);
        }

        public static void Send<T>(MessageNames messageName, T message)
        {
            Send(GetKey<T>(messageName), message);
        }

        private static void Send<T>(string messageName, T message)
        {
            if (!RegisteredActions.ContainsKey(messageName))
                return;

            var actions = RegisteredActions[messageName];
            foreach (var action in actions)
            {
                var messageAction = action as Action<T>;
                messageAction?.Invoke(message);
            }
        }

        private static string GetKey<T>(MessageNames messageName)
        {
            return $"{messageName};{GetKey<T>()}";
        }

        private static string GetKey<T>()
        {
            return typeof(T).FullName;
        }

    }

}