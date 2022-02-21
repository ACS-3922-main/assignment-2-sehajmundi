using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWalls : MonoBehaviour{

    AudioSource audio;

    void Start(){
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D hitInfo) {
        if (hitInfo.name == "Ball") {
            GetComponent<AudioSource>().Play();
            string wallName = transform.name;
            GameObject.Find("Canvas").GetComponent<UIManager>().Score(wallName);
        }
    }

}
