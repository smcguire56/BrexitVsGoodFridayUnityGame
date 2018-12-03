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
        SceneManager.LoadScene("chapterScene", LoadSceneMode.Single);
    }

    public void OptionsMenu(string LevelName)
    {
        SceneManager.LoadScene("optionsScene", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Chapter1(string LevelName)
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void Chapter2(string LevelName)
    {
        SceneManager.LoadScene("Chapter2", LoadSceneMode.Single);
    }

    public void Chapter3(string LevelName)
    {
        SceneManager.LoadScene("Chapter3", LoadSceneMode.Single);
    }

    public void Back(string LevelName)
    {
        SceneManager.LoadScene("mainMenu", LoadSceneMode.Single);
    }
}
