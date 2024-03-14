using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    //[SerializeField] AudioSource deathSound;

    public AudioClip AudioClipDeath;
    private AudioSource audioManager;
    private Animator anim;
    public GameObject gameOverUI;

    bool dead = false;

    void Start(){
        audioManager = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        gameOverUI = GameObject.Find("GameOverScreen");
        Debug.Log("gameOverUI found, value is " + gameOverUI.name);
        gameOverUI.SetActive(false);
    }
    void Update()
    {
        if (transform.position.y < -8.0f && !dead)
        {
            Death();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.CompareTag("death") || other.CompareTag("Bush")) && playerMovement.Shielded == false)
        {
            Death();
        }else if ((other.CompareTag("death") || other.CompareTag("Bush")) && playerMovement.Shielded == true){
            print("Get Death");
            playerMovement.setShield(false);
            playerMovement.setShield2(false);
        }
    }

    private void Death()
    {
        dead = true;
        GameOverScreen.dead = true;
        gameOverUI.SetActive(true);
        Debug.Log("death has been set to true");
        //Invoke(nameof(ReloadLevel), 0f);
        //audioManager.PlayOneShot(AudioClipDeath, 0.7f);
        //deathSound.Play();
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
