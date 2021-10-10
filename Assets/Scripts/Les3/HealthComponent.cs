using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    [SerializeField] private float _currentHealth;
    [SerializeField] private float _startHealth;
    public float CurrentHealth
    {
        get { return _currentHealth; }
    }
    // Start is called before the first frame update
    private void Awake()
    {
        _currentHealth = _startHealth;
    }

    public void TakeDamage(float amount)
    {
        _currentHealth -= amount;
        handleTakeDamage();
        if( _currentHealth <= 0)
        {
            Death();
        }
    } 

    protected virtual void handleTakeDamage()
    {
        print("Ik krijg damage");
    }
    protected virtual void Death()
    {
        print("Ik ben dood");
    }
}
