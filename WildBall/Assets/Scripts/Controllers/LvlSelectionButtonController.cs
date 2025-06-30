using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LvlSelectionButtonController : MonoBehaviour
{


    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        int index = Convert.ToInt32(GetComponentInChildren<TextMeshProUGUI>().text);
        Debug.Log(index);
        SceneManager.LoadScene(index); 
    }

    void ActivateButton()
    {
        GetComponentInChildren<Image>().gameObject.SetActive(false);
    }

}
