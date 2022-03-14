using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D _rb;
    private float _speed = 200.0f;

    void Start(){
        _rb = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
    }

    void GoBall() {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);
        _rb.AddForce(new Vector2(x, y)*_speed);
        
    }

    public void ResetBall() {
        _rb.velocity = Vector2.zero;
        transform.position = Vector3.zero;
    }

    public void Restart() {
        ResetBall();
        Invoke("GoBall", 1);
    }
}
