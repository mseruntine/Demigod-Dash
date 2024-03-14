using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator> ();
        anim.SetBool("Shielded", false);
        anim.SetBool("Shield Break", false);
    }

    // Update is called once per frame
    void Update()
    {
        if(playerMovement.getShield()){
            anim.SetBool("Shielded", true);
        }
        else if(!playerMovement.getShield2()){
            anim.SetBool("Shielded", false);
            anim.SetBool("Shield Break", true);
        }else{
            anim.SetBool("Shielded", false);
            anim.SetBool("Shield Break", false);
        }
        
    }
}
