using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

public class PassarFase : MonoBehaviour
{
    float limite = 60;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= limite)
        {
            SceneManager.LoadScene(2);
        }
    }
}
