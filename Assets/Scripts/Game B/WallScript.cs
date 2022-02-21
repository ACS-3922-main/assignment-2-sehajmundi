using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D hitInfo) {
        if (hitInfo.name == "Ball") {
            string wallName = transform.name;
            GameObject.Find("Main Camera").GetComponent<UIScript>().Miss();
        }
    }
}
