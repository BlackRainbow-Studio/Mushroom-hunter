using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    [SerializeField] public Transform endPoint;

    private void OnTriggerEnter(Collider other)
    {
        // когда коддайдится с Avatar -> создавать новый Chunk
    }
}
