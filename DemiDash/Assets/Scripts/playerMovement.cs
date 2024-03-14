using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] private float MoveSpeed;
    [SerializeField] private float JumpForce;

    public int MaxJumps = 1;
    public static bool Shielded = false;
    public static bool Shielded2 = false;
    public static bool Shieldbreak = false;
    private Rigidbody2D rb;
    private Animator anim;
    public float animSpeed;
    public AudioClip AudioClipJump;
    private AudioSource audioManager;
    private float moveDircetion;
    private int jumpsRemaining;

     private void OnCollisionEnter2D(Collision2D collision)
    {
        // Restore jumps if touching ground
       
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpsRemaining = MaxJumps;
            anim.SetBool("Jump", false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator> ();
        audioManager = GetComponent<AudioSource>();
        Shielded = false;
        Shielded2 = false;
        Shieldbreak = false;
    }

    // Update is called once per frame
    void Update()
    {
        //get input
        //moveDircetion = Input.GetAxis("Horizontal");

        //move
        //rb.velocity = new Vector2(moveDircetion * MoveSpeed, rb.velocity.y); 
        // anim.SetBool("Jump", false);
        if(Input.GetKey("s")){
            anim.SetBool("Shielded", true);
            Shielded = true;
        }
        if(Shielded2 == false){
            anim.SetBool("Shield Break", true);
            anim.SetBool("Shielded", true);
            Shieldbreak = true;
        }
        if(Shieldbreak == true){
            Shieldbreak = false;
            Shielded2 = true;
            anim.SetBool("Shield Break", false);
            anim.SetBool("Shielded", false);
        }
        if (jumpsRemaining > 0 && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
            jumpsRemaining--;
            anim.SetBool("Jump", true);
            audioManager.PlayOneShot(AudioClipJump, 0.7f);
        }
    }
    public static void setShield2(bool Shield){
        Shielded2 = Shield;
    }
    public static void setShield(bool Shield){
        Shielded = Shield;
    }
    public static bool getShield(){
        return Shielded;
    }
    public static bool getShield2(){
        return Shielded2;
    }

}
