using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CREDITOS : MonoBehaviour
{
    public Button btFechar;
    // Start is called before the first frame update
    void Start()
    {
        
        btFechar.onClick.AddListener(Sair);

    }

    public void Sair()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

}
