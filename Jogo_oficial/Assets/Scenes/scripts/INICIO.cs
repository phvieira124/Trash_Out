using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class INICIO : MonoBehaviour
{
    public Button btPular;

    void Start()
    {
        btPular.onClick.AddListener(Pulo);
    }

    
    public void Pulo()
    {
        SceneManager.LoadScene(1);
        
    }
}
