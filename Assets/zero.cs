using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zero : MonoBehaviour
{
    public float speed;
	Rigidbody2D rb;
    Animator animator;
    SpriteRenderer sr;
    Transform tf;
    bool onGround;
    int maxJump = 2;
    int curJump = 0;

    // Start is called before the first frame update
    void Start()
    {
        speed = Time.deltaTime;             
	    rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        tf = GetComponent<Transform>();
        onGround = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)){
            sr.flipX = true;
            if(onGround)
                animator.Play("run");
            tf.Translate(new Vector2(-speed, 0));
        }
            
        if (Input.GetKey(KeyCode.RightArrow))
        {
            sr.flipX = false;
            if (onGround)
                animator.Play("run");
            tf.Translate(new Vector2(speed, 0));
        }
        if (Input.GetKeyDown(KeyCode.X) && curJump<maxJump)
        {
            animator.Play("jump");
            rb.AddForce(new Vector2(0, 200)); 
            curJump++;
        }
        if(Input.GetKeyDown(KeyCode.C))
        {
            animator.Play("attack");
        }
        if(Input.GetKeyDown(KeyCode.V))
        {
            animator.Play("thunder");
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            animator.Play("dash");
            if (sr.flipX==true)
                rb.AddForce(new Vector2(-140, 0));
            else rb.AddForce(new Vector2(140, 0));
        }
        if (Input.GetKey(KeyCode.Z) && Input.GetKey(KeyCode.V))
        {
            animator.Play("hurricane");
        }
        if (Input.GetKeyDown(KeyCode.V) && !onGround)
        {
            animator.Play("ice");
        }
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKeyDown(KeyCode.V))
        {
            animator.Play("flame");
            rb.AddForce(new Vector2(0, 200));
        }


    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "ground")
        {
            onGround = true;
            curJump = 0;
        }
    }
    void OnCollisionExit2D(Collision2D col)
    {
        if(col.gameObject.name=="ground")  
            onGround = false;
    }

}
