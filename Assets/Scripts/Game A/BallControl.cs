using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float _speed = 25.0f;
    AudioSource audio;

    void Start(){
        _rb = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
        Invoke("GoBall", 3);
    }

    void GoBall() {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-2.0f, -0.5f) : Random.Range(0.5f, 2.0f);
        _rb.AddForce(new Vector2(x, y)*_speed);
        
    }

    public void ResetBall() {
        _rb.velocity = Vector2.zero;
        transform.position = Vector3.zero;
    }

    public void Restart() {
        ResetBall();
        Invoke("GoBall", 2);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player" || collision.gameObject.name == "Computer" || collision.gameObject.name == "TopWall" || collision.gameObject.name == "BottomWall")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
