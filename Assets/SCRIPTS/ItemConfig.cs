using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemConfig", menuName = "Gameplay/ItemConfig")]
[System.Serializable]

public class ItemConfig : ScriptableObject
{
    [SerializeField] public GameObject prefab;
    [SerializeField] public float itemRaisedCost;
}
