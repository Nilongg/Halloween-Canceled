using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jumpscare : MonoBehaviour
{
    public string sceneName;
    public string jumpscareName;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player")) 
            SceneManager.LoadScene(jumpscareName);
    }

    
}
