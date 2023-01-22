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
        ShowMenu();
    }

    public void SwitchPanel(GameStatus status)
    {
        ShowMenu();
        switch (status)
        {
            case GameStatus.START:
                start.SetActive(true);
                break;
            case GameStatus.WIN:
                win.SetActive(true);
                break;
            case GameStatus.LOSS:
                loss.SetActive(true);
                break;
            default:
                start.SetActive(true);
                break;
        }
    }

    public void HideMenu()
    {
        this.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    public void ShowMenu()
    {
        this.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

}
