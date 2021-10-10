using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthComponent : HealthComponent
{
    [SerializeField] private HealthPlayerUI _playerHealthUI;

    private void Start()
    {
        _playerHealthUI.UpdateUI(CurrentHealth);
    }

    protected override void Death()
    {
        base.Death();
    }

    protected override void handleTakeDamage()
    {
        base.handleTakeDamage();
        _playerHealthUI.UpdateUI(CurrentHealth);
    }
}
