using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthComponent : HealthComponent
{
    [SerializeField] private playerHealthUI _playerHealthUI;

    private void Start()
    {
        _playerHealthUI.updateUI(CurrentHealth);

    }

    protected override void HandleTakeDamage()
    {
        base.HandleTakeDamage();
        _playerHealthUI.UpdateUI(CurrentHealth);
    }

    protected override void Death()
    {
        base.Death();
        print("Laad Level In");
    }
}

internal class playerHealthUI
{
    internal void updateUI(float currentHealth)
    {
        throw new NotImplementedException();
    }

    internal void UpdateUI(float currentHealth)
    {
        throw new NotImplementedException();
    }
}