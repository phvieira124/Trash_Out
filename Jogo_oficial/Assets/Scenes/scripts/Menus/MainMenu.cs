using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button btJogar, btCreditos, instrucoes;
    // Start is called before the first frame update
    void Start()
    {
        btJogar.onClick.AddListener(Jogar);
        instrucoes.onClick.AddListener(Instrucoes);
        btCreditos.onClick.AddListener(Agradecer);
    }

    public void Jogar()
    {
        SceneManager.LoadScene(2);
    }
     
    public void Agradecer()
    {
        SceneManager.LoadScene(8);
       }
  
       public void Instrucoes()
    {
        SceneManager.LoadScene(9);
    }


}