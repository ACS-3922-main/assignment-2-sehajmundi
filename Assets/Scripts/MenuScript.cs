using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void openGameA()
    {
        SceneManager.LoadScene("PartA");
    }

    public void openGameB()
    {
        SceneManager.LoadScene("PartB");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            openGameA();
        }
        else if(Input.GetKey(KeyCode.A))
        {
            openGameB();
        }
        else if(Input.GetKey(KeyCode.Q))
        {
            QuitGame();
        }
    }
}
