using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float speed = 0.10f;
    [SerializeField] Animator animator;
    public bool end = false;

    void Start() {
        animator.SetBool("Lose", false);
    }
    
    public void Process(float[] newSample, double timeStamp)
    {
        Vector3 horizontal = new Vector3(0f, 0f, 0f);
        if(newSample[2] > 1.15f) {
            horizontal = new Vector3(speed, 0f, 0f);
        }

        transform.position = transform.position + horizontal * Time.deltaTime;
        Debug.Log(newSample[2]);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player") {
            Debug.Log("You lose");
            animator.SetBool("Lose", true);  
            speed = 0;  
            end = true;
        }
    }
}