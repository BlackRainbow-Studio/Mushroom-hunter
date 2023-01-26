using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] float forwardSpeed;
    
    [SerializeField] float horizontalSpeed;
    Vector3 horizontalDirection = Vector3.right;

    [SerializeField] GameEvent_SO TargetReached;

    void Update()
    {
        MoveVertical();
        MoveHorizontal();
    }
    private void MoveVertical()
    {
        transform.Translate(Vector3.forward * forwardSpeed);
    }
    private void MoveHorizontal() 
    {
        if (Math.Abs(transform.position.x) > 3)
            horizontalDirection *= -1;
        transform.Translate(horizontalDirection * horizontalSpeed);
    }

    public void SetSpeed() { }

    private void OnTriggerEnter(Collider other)
    {
        TargetReached?.Invoke(this, this);
    }
}
