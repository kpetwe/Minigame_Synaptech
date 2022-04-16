using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAppear : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] Animator animator;

    void Start()
    {
        text.SetActive(false);
    }

    void Update() {
        if(animator.GetBool("Lose")) {
            text.SetActive(true);
        }
    }
}
