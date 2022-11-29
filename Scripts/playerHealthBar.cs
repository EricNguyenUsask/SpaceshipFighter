using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealthBar : MonoBehaviour
{
    private Image HealthBar;
    public float CurrentHealth;
    float maxHealth = 1000f;
    Player player;

    private void Start()
    {
        HealthBar = GetComponent<Image>();
        player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        CurrentHealth = player.health;
        HealthBar.fillAmount = CurrentHealth / maxHealth;

    }
}
