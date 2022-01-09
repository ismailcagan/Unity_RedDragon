using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleSpawner :BaseSpawner
{
    [SerializeField] EnemyController[] enemyies;
    protected override void Spawn()
    {
        int enemyindex = Random.Range(0, enemyies.Length);
        Instantiate(enemyies[enemyindex], this.transform);
    }
    //public GameObject enemy;
}
