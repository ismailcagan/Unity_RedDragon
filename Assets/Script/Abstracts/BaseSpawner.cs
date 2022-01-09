using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class BaseSpawner:MonoBehaviour
{
    [Range(2f, 5f)]
    [SerializeField] float maxSpawnTime = 3f;
    [Range(0.3f, 1.5f)]
    [SerializeField] float minSpawnTime = 1f;

    public float _currentSpawnTime;
    public float _timeBoundary;
    private void Start()
    {
        ResetTimes();
    }
    private void Update()
    {
        _currentSpawnTime += Time.deltaTime;
        if (_currentSpawnTime > _timeBoundary)
        {
            Spawn();
            ResetTimes();
        }
    }
     protected abstract void Spawn();
    /*{
        int enemyindex = Random.Range(0, enemyies.Length);
        Instantiate(enemyies[enemyindex], this.transform); // child olarak oluşturabilmek  için kullanıldı
    }
    */
    private void ResetTimes()
    {
        _currentSpawnTime = 0;
        _timeBoundary = Random.Range(minSpawnTime, maxSpawnTime);
    }
}
