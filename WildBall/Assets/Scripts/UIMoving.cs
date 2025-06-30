using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIMoving : MonoBehaviour
{
    [SerializeField] GameObject MainMenuPanel;
    [SerializeField] GameObject LvlSelectionPanel;
    [SerializeField] GameObject SettingsPanel;

    void Awake()
    {
        MainMenuOpen();

    }

    public void MainMenuOpen()
    {
        MainMenuPanel.SetActive(true);
        LvlSelectionPanel.SetActive(false);
        SettingsPanel.SetActive(false);
    }

    public void LvlSelectionOpen()
    {
        MainMenuPanel.SetActive(false);
        LvlSelectionPanel.SetActive(true);
        SettingsPanel.SetActive(false);
        
    }

    public void SettingsPanelOpen() 
    {
        MainMenuPanel.SetActive(false);
        LvlSelectionPanel.SetActive(false);
        SettingsPanel.SetActive(true);
    }
}
