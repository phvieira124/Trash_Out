using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class Shooting : MonoBehaviour
{
    float VeloBala = 500f;
    public Transform Barrel;
    public Rigidbody2D Bala;


    public void atirar()
    {
        Fire();
    }

    // Update is called once per frame
   /* void Update()
    {

        if (CrossPlatformInputManager.GetButton("Fire1"))
          

    }*/

         void Fire()
    {
        var firedBullet = Instantiate(Bala, Barrel.position, Barrel.rotation);
        firedBullet.AddForce(Barrel.up * VeloBala);

    }

}

