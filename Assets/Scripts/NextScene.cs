using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextScene : MonoBehaviour
{
    public int nextScene = 1;
    public int seconds = 2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(count());
    }

   

    IEnumerator count()
    {
        
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(nextScene);
        
    }
}
