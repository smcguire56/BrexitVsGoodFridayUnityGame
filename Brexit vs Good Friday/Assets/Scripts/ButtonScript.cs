using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {

    // for the main menu I've set up methods for each button
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

    // quits the game from in game 
    public void QuitGame()
    {
        Application.Quit();
    }

    // will allow user to go straignt into specific chapter
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

    // loads main menu 
    public void Back(string LevelName)
    {
        SceneManager.LoadScene("mainMenu", LoadSceneMode.Single);
    }
}
