using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]  // bu script rigidbodysd alacak demek, scripti attığım nesnenin git ridigbody2d al
public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    Rigidbody2D _rigidbody2D;
    [SerializeField] DirectionEnum direction;
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        
        _rigidbody2D.velocity = SelectNewDirection() * moveSpeed;

        /*
         velocity => verilen hızda başlar ve verilen hızda devam eder
        addforce => hızı sıfırdan başlar ve yavaş yavaş verilen hıza doğru devam eder.
         */
    }

    private Vector2 SelectNewDirection()
    {
        Vector2 selectedDirection;

        if (direction == DirectionEnum.Left)
        {
            selectedDirection = Vector2.left;
        }
        else
        {
            selectedDirection = Vector2.right;
        }
        return selectedDirection;
    }

}
