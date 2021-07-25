using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death_Scene : MonoBehaviour
{
    public void RestartGame() {
        Debug.Log("Restarting game...");
        SceneManager.LoadScene("MainGame");
    }

    public void ExitGame() {
        Debug.Log("Exiting Fluppy Drone...");
        Application.Quit();
    }
}
