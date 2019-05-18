using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelaDeVitoria: MonoBehaviour
{
    public Button btMenuPrincipal, btAvancar;
    // Start is called before the first frame update
    void Start()
    {

        btMenuPrincipal.onClick.AddListener(Sair);
        btAvancar.onClick.AddListener(Fases);
    }

    public void Sair()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void Fases()
    {
        SceneManager.LoadScene("MenuFases");
    }

}
