using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new GameEvent", menuName = "Core/GameEvent")]
[System.Serializable]
public class GameEvent_SO : ScriptableObject
{
    [SerializeField] bool writeDebug = true;
    private List<GameEvent_Listener> listeners = new List<GameEvent_Listener>();

    public void Invoke<T>(object sender, T data)
    {
        if (writeDebug)
            Debug.Log($"'{sender}' invokes '{this.name}' event with '{data}' data.");
        for (int i = 0; i < listeners.Count; i++)
		{
            listeners[i].OnEventInvoked(data);
		}
    }

    public void Subscribe(GameEvent_Listener listener)
	{
        if (!listeners.Contains(listener))
            listeners.Add(listener);
	}

    public void Unsubscribe(GameEvent_Listener listener)
    {
        if (listeners.Contains(listener))
            listeners.Remove(listener);
    }
}

