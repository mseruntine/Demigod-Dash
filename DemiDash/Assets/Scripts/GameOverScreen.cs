using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    //public GameObject gameOverUI;
    public static bool dead;
    void Start()
    {
        dead = false;
        Debug.Log("death has been set to false");
        
    }

    private void Update()
    {
        if (dead)
        {
            gameObject.SetActive(true);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadMenu() {

        SceneManager.LoadScene("Menu");

    }
}
