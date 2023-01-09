using System;
using System.Reflection;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Компонент слушает Scriptable событие и вызывает метод другого компонента.
/// </summary>
public class GameEvent_Listener : MonoBehaviour
{
    public GameEvent_SO gameEvent;
	public UnityEvent response;

	private void OnEnable()
	{
		gameEvent.Subscribe(this);
	}
	private void OnDisable()
	{
		gameEvent.Unsubscribe(this);
	}


	// Нужно добавить обработку множественных слушателей
	// Добавить проверку на соответствие типов
	public void OnEventInvoked<T>(T data)
	{
		object classInstance = response.GetPersistentTarget(0);
		Type type = classInstance.GetType();
		if (type != null)
		{
			string methodName = response.GetPersistentMethodName(0);
			MethodInfo methodInfo = type.GetMethod(methodName);

			if (methodInfo != null)
			{
				ParameterInfo[] parameters = methodInfo.GetParameters();

				if (parameters.Length == 0)
				{
					methodInfo.Invoke(classInstance, null);
				}
				else
				{
					object[] parametersArray = new object[] { data };
					methodInfo.Invoke(classInstance, parametersArray);
				}
			}
		}
	}
}
