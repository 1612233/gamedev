using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    Transform tf;
    float speed = 0.001f;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tf.position.x < 0 || tf.position.x >1.46)
            speed = -speed;
        if (speed > 0)
            sr.flipX = true;
        else sr.flipX = false;
        tf.Translate(new Vector2(speed, 0));
    }
}
