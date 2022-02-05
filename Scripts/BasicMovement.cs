using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float speed = 0.10f;
    PlayerMovement PlayerMovement;
    public GameObject Player;
    public Animator animator;
    // Start is called before the first frame update
    void Awake()
    {
        PlayerMovement = Player.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 90)
        {
            Debug.Log("You've won");
        }
        if (Input.GetKey("left"))
        {
            speed -= 0.01f;
            animator.SetFloat("speed", speed);
        }
        if (Input.GetKey("right"))
        {
            speed += 0.01f;
            animator.SetFloat("speed", speed);
        }
        // if stress -> increase spd
        // if calm -> decrease spd
        // if spd of villain > spd of character
        Vector3 horizontal = new Vector3(speed, 0, 0);
            // close distance: villain's spd is positive -> run animation
        // if spd of villain < spd of character
            // villain's spd is negative -> walk animation
            // can only reaches at the end of screen
        // if spd of villain == spd of character
            // villain's spd == 0 walk animation
        transform.position = transform.position + horizontal * Time.deltaTime;
        
        // Print winning message 
    }

    //On collision
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("You lose");
        }
    }
}
