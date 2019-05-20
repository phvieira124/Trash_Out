
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Button /*btReiniciar,*/ btMenuPrincipal;
    // Start is called before the first frame update
    void Start()
    {
//        btReiniciar.onClick.AddListener(Reiniciar);
        btMenuPrincipal.onClick.AddListener(Sair);
       
    }
/*
    public void Reiniciar()
    {
        SceneManager.LoadScene("Fases");
    }
*/
    public void Sair()
    {
        SceneManager.LoadScene(1);
    }
    
}

