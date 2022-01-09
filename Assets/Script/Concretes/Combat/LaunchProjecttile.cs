using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjecttile : MonoBehaviour
{
    [SerializeField] ProjectTileController projecttilePrefab; // fırlatılacak nesne game object yapılabilir
    [SerializeField] GameObject projectileParent;
    [SerializeField] Transform projecttiletransform;         // fırlatılacak posizyon
    [SerializeField] float delayProjecttile = 1f;            // bekleme süresi saniyede 1 ateşle

    float _currentDelayTime = 0f;
    bool _canLaunch = false;

    private void Update()
    {
        _currentDelayTime += Time.deltaTime;
        if (_currentDelayTime > delayProjecttile)
        {
            _canLaunch = true;
            _currentDelayTime = 0;
        }
    }
    public void LaunchAction()
    {
        if (_canLaunch)
        {
            ProjectTileController newProjecttile= Instantiate(projecttilePrefab, projecttiletransform.position, projecttiletransform.rotation);
            newProjecttile.transform.parent = projectileParent.transform;
            _canLaunch = false;
        }
    }
}
