using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

public class PassarFase : MonoBehaviour
{
    float limiteTempo = 100000;
    int passar = 0;
    

    public void FixedUpdate()
    {
        if (Time.time >= limiteTempo)
        {
            Passar();
        }
    }

    public void Passar()
    {
       
    }
}
