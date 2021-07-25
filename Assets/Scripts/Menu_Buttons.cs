using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Buttons : MonoBehaviour
{
    public void PlayGame(){
        Debug.Log("Starting Flappy Drone...");
        SceneManager.LoadScene("MainGame");
    }

    public void ExitGame() {
        Debug.Log("Exiting Fluppy Drone...");
        Application.Quit();
    }

}
