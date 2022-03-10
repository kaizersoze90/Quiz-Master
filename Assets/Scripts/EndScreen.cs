using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI endText;

    Quiz quiz;

    void Start()
    {
        quiz = FindObjectOfType<Quiz>();
        endText.text = "Congratulations!\nYour success ratio: " + PlayerPrefs.GetInt("LastScore") + "%";
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }
}
