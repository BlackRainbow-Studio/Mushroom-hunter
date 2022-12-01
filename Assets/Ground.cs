using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] float speed = 1;
    void Update()
    {
        transform.Translate(Vector3.back * speed);
    }
}
