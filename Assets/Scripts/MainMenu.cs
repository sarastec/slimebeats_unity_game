using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayLevel01()
    {
        SceneManager.LoadScene("Level01");
    }

    public void PlayLevel02()
    {
        SceneManager.LoadScene("Level02");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
