using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    [SerializeField] public Transform endPoint;
    [SerializeField] private int mismatchCost = -10;

    private void OnMouseDown()
    {
        Debug.Log("Мимо!");
        Game.Instance.UpdateScore(mismatchCost);
    }
}
