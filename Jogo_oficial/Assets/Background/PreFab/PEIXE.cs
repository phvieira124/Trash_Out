using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PEIXE : MonoBehaviour
{
    public int health;
    public int ScoreValue = -15;
    protected SpriteRenderer sprite;
    // Start is called before the first frame update

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DamageEnemy(int damageBullet)
    {
        health -= damageBullet;
        StartCoroutine(Damage());

        if (health < 1)
        {
            Score.pontos += ScoreValue;
            Destroy(gameObject);
        }
    }

    IEnumerator Damage()
    {
        sprite.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        sprite.color = Color.white;

    }
}