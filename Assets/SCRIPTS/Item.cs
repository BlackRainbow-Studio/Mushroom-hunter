using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Events;
using UnityEngine.Events;

public class Item : MonoBehaviour
{
    [SerializeField] private UnityEvent onClicked;
    [SerializeField] private UnityEvent onGone;
    Score score;

    private void Start()
    {
        score = Score.Instance;
    }
    private void OnMouseDown()
    {
        //Debug.Log($"Click on {this.gameObject.name}");

        Destroy(this.gameObject);
        onClicked?.Invoke();
        score.Increase();
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log($"Lost {this.gameObject.name}");

        Destroy(this.gameObject);
        onGone?.Invoke();
        score.Decrease();
    }
}
