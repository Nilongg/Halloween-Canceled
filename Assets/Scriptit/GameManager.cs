using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int placedPumpkins;

    public TextMeshProUGUI pumpkingText;
    public TextMeshProUGUI finalText;

    private void Awake()
    {
        instance = this;

    }

    void Update()
    {
        pumpkingText.text = "Pumpkins placed: " + placedPumpkins;
        if (placedPumpkins == 5)
        {
            pumpkingText.text = "";
            finalText.text = "Congratulations, you collected all the pumpkins, now halloween shall be canceled.";
            StartCoroutine(TheEnd());
        }

    }
    IEnumerator TheEnd()
    {
        yield return new WaitForSeconds(3);
        finalText.color = Color.red;
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("JumpScare");




    }
}
