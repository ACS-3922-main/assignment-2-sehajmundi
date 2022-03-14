using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentControl : MonoBehaviour
{
    private float _speed = 13;
    private float _boundary = 2.25f;
    public float lerpSpeed = 2f;
    Rigidbody2D _rb;
    public Rigidbody2D _ball;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_ball.transform.position.y > transform.position.y)
        {
            if (_rb.velocity.y < 0) _rb.velocity = Vector2.zero;
            _rb.velocity = Vector2.Lerp(_rb.velocity, Vector2.up * _speed, lerpSpeed * Time.deltaTime);
        }
        else if (_ball.transform.position.y < transform.position.y)
        {
            if (_rb.velocity.y > 0) _rb.velocity = Vector2.zero;
            _rb.velocity = Vector2.Lerp(_rb.velocity, Vector2.down * _speed, lerpSpeed * Time.deltaTime);
        }
        else
        {
            _rb.velocity = Vector2.Lerp(_rb.velocity, Vector2.zero * _speed, lerpSpeed * Time.deltaTime);
        }
        // limits movement at boundaries
        Vector3 pos = transform.position;
        if (pos.y > _boundary) {
            pos.y = _boundary;
        }
        else if (pos.y < -_boundary) {
            pos.y = -_boundary;
        }
        transform.position = pos;
    }
}
