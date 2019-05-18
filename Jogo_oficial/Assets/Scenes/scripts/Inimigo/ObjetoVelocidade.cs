using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocidadeObjeto : MonoBehaviour
{

    public float velocidade;
    public float x;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        x = transform.position.x;
        x += velocidade * Time.deltaTime;

        transform.position = new Vector2(x, transform.position.y);

        if (x <= -5)
        {
            Destroy(transform.gameObject);
        }
    }
}
