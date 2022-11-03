using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject loadingScreen;

    private void Awake()
    {
        instance = this;
        SceneManager.LoadSceneAsync((int)SceneIndexes.TITLE_SCREEN, LoadSceneMode.Additive);

    
    }

    public void LoadGame()
    {
        SceneManager.UnloadSceneAsync((int)SceneIndexes.TITLE_SCREEN);
        SceneManager.LoadSceneAsync((int)SceneIndexes.MAP, LoadSceneMode.Additive);
        
    }
}
