using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] float verticalSpeed = 5;

    List<Chunk> chunks = new List<Chunk>();
    [SerializeField] GameObject chunkPrefab;
    Chunk lastChunk;

    [SerializeField] Transform innerPoint;
    [SerializeField] Transform outerPoint;

    private void Start()
    {
        chunks.Add(Instantiate(chunkPrefab, Vector3.zero, Quaternion.identity, transform).GetComponent<Chunk>());
        lastChunk = chunks[chunks.Count - 1];
    }

    void Update()
    {
        Move();

        if (lastChunk.endPoint.position.z <= innerPoint.position.z)
        {
            NewChunk();
        }
        
        if (chunks[0].endPoint.position.z <= outerPoint.position.z)
        {
            Destroy(chunks[0].gameObject);
            chunks.Remove(chunks[0]);
        }
    }

    void NewChunk()
    {
        // Добавить обработку exception для chunk[0] сюда из Start
        chunks.Add(Instantiate(chunkPrefab, lastChunk.endPoint.position, Quaternion.identity, transform).GetComponent<Chunk>());
        lastChunk = chunks[chunks.Count - 1];
    }
    private void Move()
    {
        transform.Translate(Vector3.back * verticalSpeed * 0.01f);
    }
}
