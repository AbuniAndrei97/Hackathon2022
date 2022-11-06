using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PlayerHealth : MonoBehaviour
{
    public int maxHealth=20;
    public int currentHealth;
    public HealthBar healthBar;
    public UnityEvent onDead;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    void Update()
    {
        if( Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
        }
        if( currentHealth <= 0)
        {

            onDead?.Invoke();
            Time.timeScale=0;
        }
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

}
