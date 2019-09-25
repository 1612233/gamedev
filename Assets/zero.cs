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
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.02f;             //5f
	    rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)){
            sr.flipX = true;
            animator.Play("run");
            tf.Translate(new Vector2(-speed, 0));
            //rb.AddForce(new Vector2(-speed, 0));
        }
            
        if (Input.GetKey(KeyCode.RightArrow))
        {
            sr.flipX = false;
            animator.Play("run");
            //rb.AddForce(new Vector2(speed, 0));
            tf.Translate(new Vector2(speed, 0));
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            animator.Play("jump");
            rb.AddForce(new Vector2(0, 200));
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
                rb.AddForce(new Vector2(-150, 0));
            else rb.AddForce(new Vector2(150, 0));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.Play("hurricane");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.Play("ice");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.Play("flame");
            rb.AddForce(new Vector2(0, 200));
        }


    }
}
