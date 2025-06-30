using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    int ScenesCount = 5;

    private void Start()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NextSceneTrigger"))
        {
            int nextIndexScene = SceneManager.GetActiveScene().buildIndex + 1;  
            if (nextIndexScene > ScenesCount)
            {
                LoadMainMenuScene();
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        else if (other.CompareTag("DeathTrigger"))
        {

        }

    }

    private void LoadSceen(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene(0);
    } 

}
