using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Item : MonoBehaviour
{
    Game game;
    [SerializeField] UnityEvent onItemRaised;

    [SerializeField] int itemPickedCost = 10;
    [SerializeField] int itemLosedCost = -5;

    private void Start()
    {
        game = Game.Instance;
    }
    private void OnMouseDown()
    {
        //Debug.Log($"Click on {this.gameObject.name}");

        Destroy(this.gameObject);
        game.UpdateScore(itemPickedCost);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log($"Lost {this.gameObject.name}");

        Destroy(this.gameObject);
        game.UpdateScore(itemLosedCost);
    }

    private void Raise()
    {
        onItemRaised?.Invoke();
    }
}
