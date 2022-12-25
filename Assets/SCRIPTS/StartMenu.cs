using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 0;
    }

    public void StartGame()
    {
        this.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    public void PauseGame()
    {

    }

}
