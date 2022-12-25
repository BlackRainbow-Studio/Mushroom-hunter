using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SettingsTool : MonoBehaviour
{
    [SerializeField] TMP_Text speed;
    [SerializeField] TMP_Text density;

    void Update()
    {
        speed.text = "speed:" + Level.Instance.verticalSpeed;
    }
}
