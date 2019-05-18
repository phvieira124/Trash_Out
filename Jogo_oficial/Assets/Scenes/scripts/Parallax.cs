using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private Material CurrentMaterial;
    public float speed;
    private float Offset;



    // Start is called before the first frame update
    void Start()
    {
        CurrentMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        Offset += speed * Time.deltaTime;
        CurrentMaterial.SetTextureOffset("_MainTex", new Vector2(Offset, 0));

    }
}
