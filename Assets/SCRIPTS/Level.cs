using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public static Level Instance;

    public float verticalSpeed = 5;
    [SerializeField] float verticalSpeedSettingStep;
    [SerializeField] Transform _movingPlatform;

    List<Chunk> chunks = new List<Chunk>();
    [SerializeField] GameObject chunkPrefab;
    Chunk lastChunk;

    [SerializeField] Transform innerPoint;
    [SerializeField] Transform outerPoint;

    private void Awake()
    {
        if (!Instance)
            Instance = this;
    }
    private void Start()
    {
        chunks.Add(Instantiate(chunkPrefab, Vector3.zero, Quaternion.identity, transform).GetComponent<Chunk>());
        //chunks[0].
        lastChunk = chunks[chunks.Count - 1];
    }

    void FixedUpdate()
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
        chunks.Add(Instantiate(chunkPrefab, lastChunk.endPoint.position, Quaternion.identity, _movingPlatform).GetComponent<Chunk>());
        lastChunk = chunks[chunks.Count - 1];
        lastChunk.transform.parent = _movingPlatform;
    }
    private void Move()
    {
        _movingPlatform.Translate(Vector3.back * verticalSpeed * 0.01f);
    }

    public void IncreaseSpeed()
    {
        verticalSpeed += verticalSpeedSettingStep;
    }
    public void DecreaseSpeed()
    {
        verticalSpeed -= verticalSpeedSettingStep;
    }
}
