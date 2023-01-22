using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemConfig", menuName = "Gameplay/ItemConfig")]
[System.Serializable]

public class ItemConfig : ScriptableObject
{
    [SerializeField] public string name;
    [SerializeField] public GameObject prefab;
    [SerializeField] public AudioClip onRaisedSound;
    [SerializeField] public float itemRaisedCost;
}
