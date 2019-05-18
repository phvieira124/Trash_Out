using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public int Vida;
    public GameObject DeathEffect;


    private void Update()
    {
        if (Vida <= 0)
        {
            Instantiate(DeathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }

    public void TomaDano(int Dano)
    {
        Vida -= Dano;
    }
  
   
       
        


}

