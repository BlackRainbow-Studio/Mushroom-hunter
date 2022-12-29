using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject start;
    [SerializeField] GameObject win;
    [SerializeField] GameObject loss;

    private void Awake()
    {
        PauseGame();
    }

    public void StartGame()
    {
        this.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    public void PauseGame()
    {
        this.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

}
