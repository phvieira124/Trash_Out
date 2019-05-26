using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

public class PassarIntro : MonoBehaviour
{
    float limite = 5;
    // Update is called once per frame
    void Update()
    {
        if (Time.time >= limite)
        {
            SceneManager.LoadScene(1);
        }
    }
}
