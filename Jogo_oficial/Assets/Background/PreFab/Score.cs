using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int pontos;
    int n;
    int scene;
    int vitoria = 100;
    Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        pontos = 0;
        
    }


    // Update is called once per frame
    void Update()
    {
        scene = SceneManager.GetActiveScene().buildIndex;
        text.text = "Pontos:" + pontos;
        if(scene <= 7) {
            switch (scene)
            {
                case 3:
                    if (pontos >= 100)
                    {
                        SceneManager.LoadScene(scene + 1);
                    }
                    break;
                case 4:
                    if (pontos >= 200)
                    {
                        SceneManager.LoadScene(scene + 1);
                    }
                    break;
                case 5:
                    if (pontos >= 300)
                    {
                        SceneManager.LoadScene(scene + 1);
                    }
                    break;
                case 6:
                    if (pontos >= 400)
                    {
                        SceneManager.LoadScene(scene + 1);
                    }
                    break;
                case 7:
                    if (pontos >= 500)
                    {
                        SceneManager.LoadScene(scene + 1);
                    }
                    break;
                
            }

        }
    }  


}
