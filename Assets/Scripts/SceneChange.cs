using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    public float changeTime = 2f;
    void Start()
    {
        currentTime = changeTime;
    }


    void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        if (currentTime == 0)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            changeTime = currentTime;
        }
    }
    

    }

