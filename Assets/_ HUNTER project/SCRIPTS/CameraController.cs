using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform avatar;
    [SerializeField] Vector3 offset;

    void Update()
    {
        transform.position = avatar.position + offset;
    }
}
