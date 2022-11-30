using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score = 0;

    [SerializeField] TMPro.TMP_Text text;

    public void Increase()
    {
        Debug.Log("Score increased");

        score += 5;
        text.text = score.ToString();
    }
}
