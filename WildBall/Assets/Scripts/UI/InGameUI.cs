using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour
{
    [SerializeField] Button[] buttons;
    [SerializeField] GameObject pausePanel;
    int pauseButtonIndex;

    void Start()
    {
        
        for (int i = 0; i < buttons.Length; i++) {
            int index = i;
            buttons[index].onClick.AddListener(() => OnButtonClick((buttons[index]).name));

            if (buttons[index].name == "PauseButton")
                    pauseButtonIndex = index;
    }
    }


    void OnButtonClick(string name)
    {
        switch (name)
        {
            case "MainMenuButton": 
                SceneManager.LoadScene("MainMenuScene");
                Time.timeScale = 1;
                break;

            case "RestartButton":
                SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
                break;

            case "PlayButton":
                pausePanel.SetActive(false);
                buttons[pauseButtonIndex].gameObject.SetActive(true);
                Time.timeScale = 1;
                break;

            case "PauseButton":
                pausePanel.SetActive(true);

                buttons[pauseButtonIndex].gameObject.SetActive(false);
                Time.timeScale = 0;
                break;

            case "SettingsButton":

                break;

            default: 
                break;
        }

    }


}
