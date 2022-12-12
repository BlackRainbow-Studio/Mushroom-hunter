using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score Instance;
    private int score = 0;

    [SerializeField] TMPro.TMP_Text text;

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            Debug.Log("Score initialized");
        }
    }

    public void Increase()
    {
        Debug.Log("Score increased");

        score += 5;
        text.text = score.ToString();
    }
    
    public void Decrease()
    {
        Debug.Log("Score decreased");

        score -= 10;
        text.text = score.ToString();
    }
}
