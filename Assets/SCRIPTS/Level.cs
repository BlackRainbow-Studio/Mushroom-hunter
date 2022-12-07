using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] float verticalSpeed = 5;

    List<Chunk> chunks = new List<Chunk>();
    [SerializeField] GameObject chunkPrefab;

    [SerializeField] Transform innerPoint;
    [SerializeField] Transform outerPoint;

    private void Start()
    {
        Instantiate(chunkPrefab, Vector3.zero, Quaternion.identity, transform);
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.back * verticalSpeed * 0.01f);
    }
}
