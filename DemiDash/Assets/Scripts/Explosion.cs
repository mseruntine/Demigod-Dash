using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D target){
        if(target.tag == "Player"){
            if(tag == "Bush"){
                // anim.SetBool("Explosion", true);

                StartCoroutine (Dead (0f));
            }
        }
    }

    IEnumerator Dead(float timer) {
        yield return new WaitForSeconds (timer);
        gameObject.SetActive (false);
    }
}
