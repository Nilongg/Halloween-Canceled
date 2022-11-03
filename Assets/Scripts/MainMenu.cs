using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public string SceneNimi;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneNimi);
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QUIT");
    }
}
