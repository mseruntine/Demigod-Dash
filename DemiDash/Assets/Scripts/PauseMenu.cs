using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        
        // User hits escape key
        if(Input.GetKeyDown(KeyCode.Escape)) {

            // If game already paused, exit pause menu
            if(GameIsPaused) {

                Resume();

            // If game not paused, enable pause menu
            } else {

                Pause();

            }

        }

    }

    public void Resume() {

        Debug.Log("Resuming Game...");
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    void Pause() {

        Debug.Log("Pausing Game...");
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        
    }

    public void LoadMenu() {

        SceneManager.LoadScene("Menu");
        GameIsPaused = false;
        Time.timeScale = 1f;

    }

    public void LoadTutorial() {

        SceneManager.LoadScene("Tutorial Level");
        GameIsPaused = false;
        Time.timeScale = 1f;

    }

    public void LoadOlympus() {

        SceneManager.LoadScene("Olympus Level");
        GameIsPaused = false;
        Time.timeScale = 1f;

    }

    // Implement Garden Level
    public void LoadGarden() {

        SceneManager.LoadScene("Garden Level");
        GameIsPaused = false;
        Time.timeScale = 1f;

    }

    public void QuitGame() {

        Debug.Log("Quitting Game...");
        Application.Quit();

    }
}
