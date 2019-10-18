using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    private const float MINX= -5f;
    private const float MAXX= 5.3f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("zero");
        offset=new Vector3(0, 0.15f, transform.position.z - player.transform.position.z);
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = player.transform.position;
        if (pos.x > MINX && pos.x < MAXX)
            transform.position = pos + offset;
        else if (pos.x < MINX)
            transform.position = new Vector3(MINX, pos.y, pos.z) + offset;
        else if (pos.x >MAXX)
            transform.position = new Vector3(MAXX, pos.y, pos.z) + offset;
    }
}
