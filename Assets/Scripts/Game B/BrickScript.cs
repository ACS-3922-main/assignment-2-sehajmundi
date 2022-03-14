using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{

    // Start is called before the first frame update
    private void Hit()
    {
        this.gameObject.SetActive(false);
        FindObjectOfType<UIScript>().Hit();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            Hit();
        }
    }
}
