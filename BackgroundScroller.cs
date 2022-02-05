using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [Range(-1f,1f)]
    public float scrollSpeed = 0.5f;
    private float offset;
    private Material mat;
    //scrollSpeed = the Scroll Speed, offset = the offset used in the calculation to remove distortion, mat = referring to the material used as the background
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    void Update()
    {
        offset += (Time.deltaTime * scrollSpeed) / 10f;
        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
        //This I don't really understand other than it calculates an offset which removes distortion between the edges of the looping background
    }
}
