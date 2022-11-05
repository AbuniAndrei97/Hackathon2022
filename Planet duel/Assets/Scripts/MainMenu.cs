using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // //audio
    // public static MusicControlScript instance;

    // private void Awake()

    // if (instance == null)
    // {
    //     instance=this;
    // }
    // else
    // {
    //     Destroy(gameObject);
    // }

    //scenes switch
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {   
        Debug.Log("Quit");
        Application.Quit();
    }

    
}
