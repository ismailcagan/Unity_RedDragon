using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LifeCycleController:MonoBehaviour
{

    [SerializeField] float maxLifeTime = 3f;
    public float _currentTime;

    private void Update()
    {
        _currentTime += Time.deltaTime;
        if (_currentTime > maxLifeTime)
        {
            Destroy(gameObject);
        }
    }
}
