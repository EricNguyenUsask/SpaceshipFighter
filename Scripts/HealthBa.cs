using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBa : MonoBehaviour
{
    private Image HealthBar;
    public float CurrentHealth;
    Enemy enemy;
    EnemySpawner spawner;

    private void Start()
    {
        HealthBar = GetComponent<Image>();
        enemy = FindObjectOfType<Enemy>();
        spawner = FindObjectOfType<EnemySpawner>();
        

    }

    private void Update()
    {
        CurrentHealth = enemy.health;
        HealthBar.fillAmount = CurrentHealth / (100+ spawner.enemyNum -1);
        Debug.Log(100 + spawner.enemyNum-1);
        
    }
}
