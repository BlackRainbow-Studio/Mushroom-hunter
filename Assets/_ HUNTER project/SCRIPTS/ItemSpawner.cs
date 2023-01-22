using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class MapLocation       
{
    public int x;
    public int z;

    public MapLocation(int _x, int _z)
    {
        x = _x;
        z = _z;
    }
}

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;

    public int width = 4; //x length
    public int depth = 8; //z length
    public int scale = 5;
    public int[,] map;

    [SerializeField] List<ItemConfig> itemPrefabs;
    [SerializeField] int generationChance = 50;

    void Start()
    {
        InitializeMap();
        GenerateMap();
        SpawnItems();
    }

    private void InitializeMap()
    {
        map = new int[width, depth];

        for (int z = 0; z < depth; z++)
            for (int x = 0; x < width; x++)
            {
                map[x, z] = -1;
            }
    }

    void GenerateMap()
    {

        for (int z = 0; z < depth; z++)
            for (int x = 0; x < width; x++)
            {
                if (Random.Range(0, 100) < generationChance)
                    if (Random.Range(0, 10) < 50)
                        map[x, z] = 0;
                    else
                        map[x, z] = 1;
            }
    }

    void SpawnItems()
    {
        for (int z = 0; z < depth; z++)
            for (int x = 0; x < width; x++)
            {
                if (map[x, z] != -1)
                    SpawnItem(x, z);
            }

        void SpawnItem(int x, int z)
        {
            Vector3 pos = new Vector3(x * scale, 0, z * scale);
            GameObject item = Instantiate(itemPrefabs[map[x, z]].prefab);
            item.transform.parent = spawnPoint;
            item.transform.localPosition = pos;
        }
    }
}
