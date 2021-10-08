using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemyRangeChecker))]
public class Tower : MonoBehaviour
{
    private EnemyRangeChecker _enemyRangeChecker;
    private void Start()
    {
        _enemyRangeChecker = GetComponent<EnemyRangeChecker>();
    }

    private void Update()
    {
        Enemy enemy = _enemyRangeChecker.GetfirstEnemyInRange();
        if(enemy != null)
        {
            print(enemy.name);
        }
    }
}
