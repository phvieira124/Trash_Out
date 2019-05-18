using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Controle : MonoBehaviour
{
    public Button BtMenu;
   void   uptade()
    {
        BtMenu.onClick.AddListener(MenuPrincipal);

    }

    private void MenuPrincipal()
    {
        throw new NotImplementedException();
    }

    public GameObject PainelMenu;

   
    public void PausarJogo()
    {
        PainelMenu.SetActive(true);
        Time.timeScale = 0f;
    }

public void ContinuarJogo()
    {

        PainelMenu.SetActive(false);
        Time.timeScale = 1f;

    }

    public void voltar()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }


}
