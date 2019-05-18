using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleButton : MonoBehaviour
{
     GameObject[] pause;
  

    private void Start()
    {
        pause = GameObject.FindGameObjectsWithTag("pause");


       foreach (GameObject pauobj in pause){
        pauobj.SetActive(false);
        }

}

    public void Mutar()
    {
        AudioListener.pause = !AudioListener.pause;
    }
}