using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoVelocidade : MonoBehaviour
{
    public float velocidade;
    public float x;
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
