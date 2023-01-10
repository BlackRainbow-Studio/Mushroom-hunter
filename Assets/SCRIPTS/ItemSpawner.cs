using System.Collections;
using System.Collections.Generic;
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
    public byte[,] map;

    [SerializeField] GameObject itemPrefab;
    [SerializeField] GameObject itemPrefab2;
    [SerializeField] int generationChance = 50;

    void Start()
    {
        GenerateMap();
        SpawnItems();
    }

    void GenerateMap()
    {
        map = new byte[width,depth];
        
        for (int z = 0; z < depth; z++)
            for (int x = 0; x < width; x++)
            {
                    map[x, z] = 0;
            }

        for (int z = 0; z < depth; z++)
            for (int x = 0; x < width; x++)
            {
               if(Random.Range(0,100) < generationChance)
                 map[x, z] = 1;     // 1 = item  0 = empty
            }
    }

    void SpawnItems()
    {
        for (int z = 0; z < depth; z++)
            for (int x = 0; x < width; x++)
            {
                if (map[x, z] == 1)
                {
                    Vector3 pos = new Vector3(x * scale, 0, z * scale);
                    GameObject item = Instantiate(itemPrefab);
                    item.transform.parent = spawnPoint;
                    item.transform.localPosition = pos;
                }
            }
    }
}
