using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameStatus { START, WIN, LOSS}

public class Game : MonoBehaviour
{
    public static Game Instance;

    [Header ("COMPONENTS")]
    [SerializeField] Avatar avatar;
    [SerializeField] Target target;
    
    [Header ("CONFIGS")]
    [SerializeField] Configuration configuration;
    [SerializeField] float maxDistance;

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
        if (this.DistanceAvatarTarget() > maxDistance)
            Fail();
    }

    public void Win() 
    {
        Debug.Log($"Win!");
    }
    public void Fail() 
    {
        Debug.Log($"Game over...!");
    }

/*    public void OnItemRaised(ItemConfig itemConfig) 
    {
        Debug.Log($"Got item {itemConfig.name}!");
        audioSource.clip = itemConfig.onRaisedSound;
        audioSource.Play();
        //Destroy(item.gameObject);
    }*/

    ////////////////////
    private float DistanceAvatarTarget()
    {
        float distance = target.transform.position.z - avatar.transform.position.z;

        return distance;
    }
}
