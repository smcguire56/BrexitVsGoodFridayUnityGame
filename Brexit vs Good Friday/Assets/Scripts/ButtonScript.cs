using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {

    public void StartGame(string LevelName)
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void ChapterSelect(string LevelName)
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void OptionsMenu(string LevelName)
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
