using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Walk : MonoBehaviour
{
    public float walkSpeed = 0.5f;
    public Animator animator;
    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        transform.Translate(Input.GetAxis("Horizontal") * walkSpeed * Time.deltaTime, 0, 0);
    }
}
