using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonManager : MonoBehaviour
{
    public int MainScene;

    public void ButtonMoveScene()
    {
        SceneManager.LoadScene(MainScene);
    }




}