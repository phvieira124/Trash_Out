using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OBJPERDIDOS : MonoBehaviour
{
    public int perdidos;
    public int maxDePerdas;
    private GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        perdidos = 0;
        maxDePerdas = 3;
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        perdidos++;
        Debug.Log("Perdidos: " + perdidos);
        if (perdidos == maxDePerdas)
        {
            SceneManager.LoadScene(10);
        }
    }
}
