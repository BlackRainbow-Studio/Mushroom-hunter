using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public static Level Instance;
    private void Awake()
    {
        if (!Instance)
            Instance = this;
    }

    [SerializeField] int stripsCount;
}
