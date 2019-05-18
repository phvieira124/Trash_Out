using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject barrairaPreFab;//Objeto Aleatório
    public float rateSpawn; //Intervalo de spawn
    public float correntTime;//Conta o tempo decorrido do objeto
    public float posicao;
    public float y;


    // Start is called before the first frame update
    void Start()
    {
        correntTime = 0;
    }

    // Update is called once per frame
    void Update()
    {



        correntTime += Time.deltaTime;
        if (correntTime >= rateSpawn)
        {
            correntTime = 0;
            posicao = Random.Range(-4, -1);

            y = posicao + 0.25F;

            GameObject tempoPreFab = Instantiate(barrairaPreFab) as GameObject;
            tempoPreFab.transform.position = new Vector2(transform.position.x, y);
            // tempoPreFab.transform.position = new Vector3(transform.position.x, y, tempoPreFab.transform.position.z);
        }
    }
}
