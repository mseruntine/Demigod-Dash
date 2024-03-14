using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelKeyController : MonoBehaviour
{
    private bool changeLevel = false;
    public AudioClip AudioClipKey;
    private AudioSource audioManager;

    void Awake (){
        audioManager = GetComponent<AudioSource>();
    
    }

    void Update() {
        ChangeLevel();
    }

    public void ChangeLevel (){
        if(changeLevel){
            // if(SceneManager.GetActiveScene().name == "Tutorial Level"){
            //     SceneManager.LoadScene("Olympus Level");
            // }else if(SceneManager.GetActiveScene().name == "Olympus Level"){
            //     SceneManager.LoadScene("Menu");
            // }else{
            if (SceneManager.GetActiveScene().name.Equals("Tutorial Level"))
                MapReveal1.showMap = true;
            if (SceneManager.GetActiveScene().name.Equals("Olympus Level"))
                MapReveal2.showMap = true;
            SceneManager.LoadScene("LevelSelect");            
            //DestroyImmediate(this.gameObject);
            //SceneManager.GetActiveScene().buildIndex - SceneManager.GetActiveScene().buildIndex
            // }
        }
    }   

    void OnTriggerEnter2D(Collider2D target) {
        if(target.tag == "Player"){
            target.gameObject.SetActive (false);
            //audioManager.PlayOneShot (AudioClipKey, 1.5f);
            changeLevel = true;
            
        }
    }

    IEnumerator WaitForSound() {
        yield return new WaitForSeconds (2f);
    }
    
}
