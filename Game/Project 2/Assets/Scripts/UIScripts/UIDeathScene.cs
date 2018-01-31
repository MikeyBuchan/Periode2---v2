using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIDeathScene : MonoBehaviour 
{

    public void RestartGame(int loadLevel1)
    {
        SceneManager.LoadScene(loadLevel1);
    }

    public void LoadMainMenu(int loadMainMenu)
    {
        SceneManager.LoadScene(loadMainMenu);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
