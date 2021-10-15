using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthComponent : HealthComponent
{
    protected override void HandleTakeDamage()
    {
        base.HandleTakeDamage();
        print("Enemy" + CurrentHealth);
    }

    protected override void Death()
    {
        base.Death();
        Destroy(gameObject);
    }
}

