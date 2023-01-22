using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -3) 
            Move(Vector3.left);
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 3) 
            Move(Vector3.right);
    }

    private void Move(Vector3 direction)
    {
        transform.Translate(direction * 2);
    }
}
