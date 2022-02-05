using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.10f;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            speed += 0.001f;
            anim.SetFloat("speed", speed);
        }
        if (Input.GetKey("left"))
        {
            speed -= 0.001f;
            anim.SetFloat("speed", speed);
        }
    }
}
