﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int health;
    public int ScoreValue = 20;
    protected SpriteRenderer sprite;
    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
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