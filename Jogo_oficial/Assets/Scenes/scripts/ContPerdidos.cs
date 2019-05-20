using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContPerdidos : MonoBehaviour
{
    public int perdidos;
    public int maxDePerdas;
    private new GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        perdidos = -1;
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
