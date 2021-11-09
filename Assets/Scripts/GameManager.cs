using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool AI;

    public GameObject ball;

    public GameObject player1;
    public GameObject player1Goal;

    public GameObject player2;
    public GameObject player2Goal;

    public Text player1Text;
    public Text player2Text;

    public int maxScore = 3;

    private int player1Score;
    private int player2Score;


    public void CheckVictory()
    {
        if (player1Score >= maxScore)
        {
            SceneManager.LoadScene("VictoryPlayer1");
        }
        if (player2Score >= maxScore)
        {
            SceneManager.LoadScene("VictoryPlayer2");
        }
    }

    public void Player1Score()
    {
        player1Score++;
        player1Text.text = player1Score.ToString();
        CheckVictory();
        ResetPosition();
    }
    public void Player2Score()
    {
        player2Score++;
        player2Text.text = player2Score.ToString();
        CheckVictory();
        ResetPosition();
    }

    private void ResetPosition()
    {        
        if (AI)
        {
            ball.GetComponent<Ball>().Reset();
            player1.GetComponent<Players>().Reset();
        }
        else
        {
            ball.GetComponent<Ball>().Reset();
            player1.GetComponent<Players>().Reset();
           // player2.GetComponent<Players>().Reset();
        }
    }
}
