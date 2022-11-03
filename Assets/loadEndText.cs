using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class loadEndText : MonoBehaviour
{
    public GameObject TextPanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(show());
    }
    IEnumerator show()
    {
        yield return new WaitForSeconds(7);
        TextPanel.SetActive(true);
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene("MenuSCENE");

    }
}
