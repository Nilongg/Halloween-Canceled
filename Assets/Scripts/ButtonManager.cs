using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonManager : MonoBehaviour
{
    public string Scene;

    public void ButtonMoveScene()
    {
        SceneManager.LoadScene(Scene);
    }




}
