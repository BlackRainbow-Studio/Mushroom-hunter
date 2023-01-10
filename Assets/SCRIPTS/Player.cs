using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Joystick _joystick;
    [SerializeField] float _moveSpeed = 5;
    private void Update()
    {
        transform.Translate(_joystick.Horizontal * _moveSpeed, 0, _joystick.Vertical * _moveSpeed);
    }

    public void SetSpeed(float speed)
    {
        _moveSpeed = speed;
    }
}
