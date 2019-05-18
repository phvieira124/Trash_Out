using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 




 public class Arma : MonoBehaviour
{
    float Range = 100f;
  public GameObject Particula;



   public void shootGun()
    { Shoot();
        Debug.Log("botao de atirar");
    }

    void Shoot()
    {
        Vector2 rayOrigin = transform.position;

        RaycastHit hit;
        if (Physics.Raycast(rayOrigin, transform.forward, out hit, Range))
        {
            Instantiate(Particula, hit.point, Quaternion.identity);
            Destroy(hit.collider.gameObject);
        }

    }





}

     

    



  

