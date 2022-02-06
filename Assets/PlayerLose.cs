using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLose : MonoBehaviour
{
    [SerializeField] Animator animator;
    void OnStart() {
        animator.SetBool("Lose", false);
    }


    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Enemy") {
            animator.SetBool("Lose", true);
        }
    }
}
