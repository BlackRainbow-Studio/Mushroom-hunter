using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Events;
using UnityEngine.Events;

public class Target : MonoBehaviour
{
    [SerializeField] private UnityEvent onClicked;
    private void OnMouseDown()
    {
        Debug.Log("Click on target");

        Destroy(this.gameObject);
        onClicked?.Invoke();
    }
}
