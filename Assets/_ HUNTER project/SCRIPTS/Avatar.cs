using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour
{
    [SerializeField] float forwardSpeed;

    private void Update()
    {
        MoveVertical();

        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -3) 
            MoveHorizontal(Vector3.left);
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 3) 
            MoveHorizontal(Vector3.right);
    }

    private void MoveHorizontal(Vector3 horizontalDirection)
    {
        transform.Translate(horizontalDirection * 2);
    }

    private void MoveVertical()
    {
        transform.Translate(Vector3.forward * forwardSpeed);
    }

    public void SetSpeed() { }
    public float GetZ()
    {
        return transform.position.z;
    }
}
