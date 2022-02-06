using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAppear : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
    }

    void Update() {
        if(enemy.GetComponent<EnemyMovement>().end) {
            text.SetActive(true);
        }
    }
}
