using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    [SerializeField] private KeyCode _moveRight = KeyCode.A;
    [SerializeField] private KeyCode _moveLeft = KeyCode.D;
    private float _speed = 8;
    private float _boundary = 20.0f;
    Rigidbody2D _rb;

    void Start() {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        // moves the paddle up or down when key pressed
        Vector2 vel = _rb.velocity;
        if (Input.GetKey(_moveLeft)) {
            vel.x = _speed;
        }
        else if (Input.GetKey(_moveRight)) {
            vel.x = -_speed;
        }
        else {
            vel.x = 0;
        }
        _rb.velocity = vel;

        // limits movement at boundaries
        Vector3 pos = transform.position;
        if (pos.x > _boundary) {
            pos.x = _boundary;
        }
        else if (pos.x < -_boundary) {
            pos.x = -_boundary;
        }
        transform.position = pos;
    }

    public void ResetPaddle()
    {
        _rb.velocity = Vector2.zero;
        transform.position = new Vector2(0f, transform.position.y);
    }
}
