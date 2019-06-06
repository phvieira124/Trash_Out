using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelecaoFases : MonoBehaviour
{
    public Button fase1, fase2, fase3, fase4, fase5, Voltar;

    // Start is called before the first frame update
    void Start()
    {
        Voltar.onClick.AddListener(Volte);
        fase1.onClick.AddListener(entrar1);
        fase2.onClick.AddListener(entrar2);
        fase3.onClick.AddListener(entrar3);
        fase4.onClick.AddListener(entrar4);
        fase5.onClick.AddListener(entrar5);
    }

    public void entrar1()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1f;

    }

    public void entrar2()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1f;
    }

    public void entrar3()
    {
        SceneManager.LoadScene(5);
        Time.timeScale = 1f;
    }

    public void entrar4()
    {
        SceneManager.LoadScene(6);
        Time.timeScale = 1f;
    }

    public void entrar5()
    {
        SceneManager.LoadScene(7);
        Time.timeScale = 1f;
    }

    public void Volte()
    {
        SceneManager.LoadScene(1);

    }


}