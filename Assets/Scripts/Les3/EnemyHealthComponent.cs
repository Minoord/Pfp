using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthComponent : HealthComponent
{
    protected override void handleTakeDamage()
    {
        base.handleTakeDamage();
    }

    protected override void Death()
    {
        base.Death();
        Destroy(gameObject);
    }
}
