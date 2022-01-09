using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] float _jumpSpeed = 200f;

    public void jumpAction(Rigidbody2D _rigidbody)
    {
        _rigidbody.velocity = Vector2.zero;
        _rigidbody.AddForce(Vector2.up * _jumpSpeed);
    }
}
