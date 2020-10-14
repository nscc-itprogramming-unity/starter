using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuScript : MonoBehaviour
{
    public GameObject playButton;
    public GameObject quitButton;
    public GameObject optionsButton;

    void Start()
    {
        playButton.GetComponent<Button>().onClick.AddListener(playButtonPressed);
        quitButton.GetComponent<Button>().onClick.AddListener(quitButtonPressed);
    }

    void playButtonPressed()
    {
        SceneManager.LoadScene("Game");
    }
    void quitButtonPressed()
    {
        Application.Quit();
    }
}
