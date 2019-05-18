using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentacaoPlayer : MonoBehaviour
{
    public float speed;
    private bool direita;
    private bool esquerda;
    private Animator PlayerAC;
    private SpriteRenderer sprite;


    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        PlayerAC = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (direita || esquerda)
        {
            PlayerAC.SetTrigger("Remando");
        }
        else
        {
            PlayerAC.SetTrigger("Parado");
        }


        if (direita)
        {
            sprite.flipY = false;
            transform.Translate(Vector2.up * speed * Time.deltaTime);
            esquerda = false;
        }
        if (esquerda)
        {
            
            transform.Translate(Vector2.down * speed * Time.deltaTime);
            direita = false;
        }


    }

    public void MovimentoDireita(bool ativo)
    {
        direita = ativo;
    }

    public void MovimentoEsquerda(bool ativo)
    {
        esquerda = ativo;
    }

}