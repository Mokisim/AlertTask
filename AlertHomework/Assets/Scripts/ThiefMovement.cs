using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ThiefMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private float _movementSpeed = 5f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector2 direction = new Vector2(x, y);

        Move(direction, x);
    }

    private void Move(Vector2 direction, float x)
    {
        _rigidbody.velocity = (new Vector2(direction.x * _movementSpeed, _rigidbody.velocity.y));
    }
}
