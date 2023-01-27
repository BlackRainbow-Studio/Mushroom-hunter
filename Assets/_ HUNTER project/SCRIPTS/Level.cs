using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] List<Chunk> chunks = new List<Chunk>();
    [SerializeField] GameObject chunkPrefab;

    private void Start()
    {
        // Add to Chunks precreated chunks, remove [serializefield] attribute
    }

    public Chunk NewChunk() 
    {
        Chunk newChunk = Instantiate(chunkPrefab).GetComponent<Chunk>();
        // parent, position, etc

        return newChunk;
    }
}
