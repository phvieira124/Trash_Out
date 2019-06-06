using UnityEngine;
using UnityEngine.SceneManagement;

public class PassarIntro : MonoBehaviour
{
    int scene;
    float limite;

    void Start()
    {
        Time.timeScale = 1f;
        limite = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        scene = SceneManager.GetActiveScene().buildIndex;
        switch (scene)
        {
            case 0:
                if (Time.time > limite)
                {
                    SceneManager.LoadScene(11);
                }
                break;
            case 11:
                if (Time.time > limite + 3)
                {
                    SceneManager.LoadScene(12);
                }
                break;
            case 12:
                if (Time.time > limite + 6)
                {
                    SceneManager.LoadScene(1);
                }
                break;
            }

    }


}

