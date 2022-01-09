using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectTileController :LifeCycleController
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyController enemy = collision.GetComponent<EnemyController>();
        if(enemy != null)
        {
            Destroy(enemy.gameObject);
            Destroy(this.gameObject);
        }
    }
}
