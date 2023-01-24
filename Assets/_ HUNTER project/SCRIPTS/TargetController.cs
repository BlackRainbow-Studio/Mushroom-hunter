using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    [SerializeField] float forwardSpeed;

    [SerializeField] GameEvent_SO TargetReached;

    void Update()
    {
        MoveVertical();
    }
    private void MoveVertical()
    {
        transform.Translate(Vector3.forward * forwardSpeed);
    }

    public void SetSpeed() { }

    private void OnTriggerEnter(Collider other)
    {
        TargetReached?.Invoke(this, this);
    }
}
