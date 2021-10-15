using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    [SerializeField]private float _startHealth;
    private float _currentHealth;
    public float CurrentHealth
    {
        get { return _currentHealth; }
    }
    
    private void start()
    {
        _currentHealth = _startHealth;

    }
    public void TakeDamage(float amount)
    {
        _currentHealth -= amount;
        if (_currentHealth <= 0)
        {
            Death();
        }
        Debug.Log("I Got Damage Chuckles");
    }

    protected virtual void HandleTakeDamage()
    {

    }
    
    protected virtual void Death()
    { 
        Debug.Log("I Died Chuckles");
    }
}
