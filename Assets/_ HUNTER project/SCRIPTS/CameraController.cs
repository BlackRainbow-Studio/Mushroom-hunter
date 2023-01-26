using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform trackingObject;
    [SerializeField] Vector3 offset;

    private void Start()
    {
        // ������������� ������ �� avatar
        offset = transform.position - trackingObject.position;
    }

    void Update()
    {
        // ���������� ������ �� y � z
        Vector3 newPosition;
        newPosition = trackingObject.position + offset;
        newPosition.x = 0;
        transform.position = newPosition;
    }
}
