using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public int score = 0;
    public int lives = 3;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text livesText;
    private int gameWinScore = 160;
    [SerializeField] private Text gameOverText;
    private GameObject _ball;

    void Start() {
        _ball = GameObject.Find("Ball");
    }

    public void Hit() {
        this.score +=10; 
        if(this.score < gameWinScore)
        {
            scoreText.text = "Score: " + score ;
        }
        else
        {
            GameOver();
        }
    }

    public void Miss() {
        this.lives--; 
        if(this.lives > 0)
        {
            _ball.GetComponent<BallScript>().Restart();
            livesText.text = "Lives: " + lives ;
        }
        else
        {
            livesText.text = "Lives: 0";
            GameOver();
        }
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void GameOver() {
        if (score == gameWinScore) {
            gameOverText.text = "PLAYER WINS";
        }
        else if (lives == 0) {
           gameOverText.text = "PLAYER LOSES\n"+"Press Q to QUIT";
        }
        gameOverText.gameObject.SetActive(true);
        _ball.GetComponent<BallScript>().ResetBall();
    }

    public void Update()
    {
        if(Input.GetKey(KeyCode.Q))
        {
            QuitGame();
        }
    }
}
