using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    float timePerLastFrame = 0;
    private void Update()
    {
        //timePerLastFrame += Time.deltaTime
        Debug.Log($"Time.deltaTime: {Time.deltaTime}");
    }
}
