using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [Range(-1f,1f)]
    // the Scroll Speed
    public float scrollSpeed = 0.5f;
    // the offset used in the calculation to remove distortion 
    private float offset;
    // referring to the material used as the background
    private Material mat;

    [SerializeField] GameObject enemy;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    void Update()
    {
        if(enemy.GetComponent<EnemyMovement>().end == false) {
            offset += (Time.deltaTime * scrollSpeed) / 10f;

        }

        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
        //This I don't really understand other than it calculates an offset which removes distortion between the edges of the looping background
    }
}
