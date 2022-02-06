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
    
    // Update is called once per frame
    void Update()
    {
        Vector3 horizontal = new Vector3(speed, 0, 0);
        transform.position = transform.position + horizontal * Time.deltaTime;
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
