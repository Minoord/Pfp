using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] private EnemyInRangeChecker _enemyInRangeChecker;
    [SerializeField] private Transform _turret;

    // Start is called before the first frame update
    void Start()
    {
        _enemyInRangeChecker = GetComponent<EnemyInRangeChecker>();   
    }

    // Update is called once per frame
    void Update()
    {
        Enemy enemy = _enemyInRangeChecker.GetFirstEnemyInRange();
        if(enemy != null)
        {
            _turret.LookAt(enemy.transform);
        }
    }
}
