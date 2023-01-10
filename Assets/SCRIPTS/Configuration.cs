using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Configuration", menuName = "Gameplay/Configuration")]
[System.Serializable]

public class Configuration : ScriptableObject
{
    [SerializeField] public float mismatchCost;
    [SerializeField] public float itemRaisedCost;

    [SerializeField] public float playerSpeed;
}
