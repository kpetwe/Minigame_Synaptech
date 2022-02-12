using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAppear : MonoBehaviour
{
    [SerializeField] GameObject[] text;
    //[SerializeField] GameObject button1;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject i in text) {
            i.SetActive(true);
        }
    }

    void Update() {

    }
}
