﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

public class PassarFase : MonoBehaviour
{
    float limite = 60;
    // Update is called once per frame
    void Update()
    {
        if (Time.time >= limite)
        {
            SceneManager.LoadScene(2);
        }
    }
}
