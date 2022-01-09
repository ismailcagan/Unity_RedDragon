using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonSpawner :BaseSpawner
{
    [SerializeField] EnemyController enemies;
    protected override void Spawn()
    {
        Instantiate(enemies, this.transform);
    }
}
