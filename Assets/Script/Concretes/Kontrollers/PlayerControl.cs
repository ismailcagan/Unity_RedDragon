using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] float _speed = 0.005f;
    
    bool _isLeftMouseClicked;
    Rigidbody2D _rigidbody;

    public GameManager GM;
    public Jump jump;
    public PCInputConroller _Input;
    LaunchProjecttile _launchProjectile;

    private void Awake()
    {
        
    }

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        jump = GetComponent<Jump>();
        _launchProjectile = GetComponent<LaunchProjecttile>();
        _Input = new PCInputConroller();
    }

   
    void Update()
    {
      //  transform.position += new Vector3(_speed, 0, 0);


        if (_Input.LeftMouseClick)
        {
            _isLeftMouseClicked = true;
        }
        if (_Input.RightMouseClick)
        {
            _launchProjectile.LaunchAction();
        }
    }

    private void FixedUpdate()
    {
        if (_isLeftMouseClicked)
        {
            jump.jumpAction(_rigidbody);
            _isLeftMouseClicked = false;
        }
        
    }
      private void OnCollisionEnter2D(Collision2D collision)
    {
        GM.Restart();
    }
}
