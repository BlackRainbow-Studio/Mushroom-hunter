using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameStatus { START, WIN, LOSS}

public class Game : MonoBehaviour
{
    public static Game Instance;

    [Header ("ACTORS")]
    [SerializeField] Avatar avatar;
    [SerializeField] Target target;
    
    [Header ("POINTS")]
    [SerializeField] Transform failPoint;
    [SerializeField] Transform generationPoint;

    [Header ("EVENTS")]
    [SerializeField] GameEvent_SO winEvent;

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            Debug.Log("Game started");
        }
    }
    private void Update()
    {
        failPoint.position = new Vector3(0, 0, avatar.GetZ());
        generationPoint.position = new Vector3(0, 0, avatar.GetZ());
    }

    public void Win() 
    {
        Debug.Log($"Win!");
    }
    public void Fail() 
    {
        Debug.Log($"Game over...!");
    }
}
