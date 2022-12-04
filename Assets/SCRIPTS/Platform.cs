using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] float verticalSpeed = 5;

    [SerializeField] Transform parent;
    [SerializeField] GameObject itemPrefab;
    [SerializeField] float xRange;

    private void Start()
    {
        GenerateItems();
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.back * verticalSpeed * 0.01f);
    }

    private void GenerateItems()
    {
        float randomX = xRange * Random.Range(-1f, 1f);
        Debug.Log(randomX);
        Instantiate(itemPrefab, parent.position + new Vector3(randomX, 0, 0), Quaternion.identity, parent);
    }
}
