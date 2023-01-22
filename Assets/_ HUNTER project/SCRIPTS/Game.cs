using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameStatus { START, WIN, LOSS}

public class Game : MonoBehaviour
{
    public static Game Instance;
    [SerializeField] Configuration configuration;
    [SerializeField] AvatarController player;
    [SerializeField] AudioSource audioSource;

    private int score = 50;

    [SerializeField] private int winRate = 200;
    [SerializeField] private int looseRate = 0;

    [SerializeField] TMPro.TMP_Text scoreText;

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            Debug.Log("Game started");
        }
    }
    private void Start()
    {
        //player.SetSpeed(configuration.playerSpeed);
    }

    public void UpdateScore(int step)
    {
        Debug.Log($"Score updated:{score} + {step}");

        score += step;
        scoreText.text = score.ToString();

        if (score > winRate)
            Win();
        if (score < looseRate)
            Loose();
    }

    public void Win() 
    {
        Debug.Log($"Win!");
    }
    public void Loose() 
    {
        Debug.Log($"Loose...!");
    }

    public void OnItemRaised(ItemConfig itemConfig) 
    {
        Debug.Log($"Got item {itemConfig.name}!");
        audioSource.clip = itemConfig.onRaisedSound;
        audioSource.Play();
        UpdateScore(50);
        //Destroy(item.gameObject);
    }
}
