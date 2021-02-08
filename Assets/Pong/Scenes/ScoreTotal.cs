using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTotal : MonoBehaviour
{
    public int p1Score = 0;
    public int p2Score = 0;
    public int winGoal = 11;
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        //canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (getPlayer1Score() >= winGoal)
        {
            Debug.Log("Game Over!");
            Debug.Log("Player 1 (Left Paddle) Wins!");
            Reset();
        }
        else if (getPlayer2Score() >= winGoal) {
            Debug.Log("Game Over!");
            Debug.Log("Player 2 (Right Paddle) Wins!");
            Reset();
        }
    }

    public int getPlayer1Score() {
        return p1Score;
    }
    public int getPlayer2Score() {
        return p2Score;
    }
    public void increasePlayer1Score() {
            p1Score++;
            //https://answers.unity.com/questions/935023/how-to-access-text-component-on-canvas-when-multip.html
            //I don't understand how to access this text element
            Transform transform = canvas.transform.Find("LeftTextScore");
            Text text = transform.GetComponent<Text>();
            text.text = p1Score.ToString();
            //canvas.enabled = true;
    }
    public void increasePlayer2Score()
    {
            p2Score++;
            //https://answers.unity.com/questions/935023/how-to-access-text-component-on-canvas-when-multip.html
            //I don't understand how to access this text element
            Transform transform = canvas.transform.Find("RightTextScore");
            Text text = transform.GetComponent<Text>();
            text.text = p2Score.ToString();
            //canvas.enabled = true;
    }
    private void Reset()
    {
        p1Score = 0;
        p2Score = 0;
        //https://answers.unity.com/questions/935023/how-to-access-text-component-on-canvas-when-multip.html
        //I don't understand how to access this text element
        Transform transform = canvas.transform.Find("LeftTextScore");
        Text text = transform.GetComponent<Text>();
        text.text = p1Score.ToString();
        //https://answers.unity.com/questions/935023/how-to-access-text-component-on-canvas-when-multip.html
        //I don't understand how to access this text element
        Transform transform2 = canvas.transform.Find("RightTextScore");
        Text text2 = transform2.GetComponent<Text>();
        text2.text = p2Score.ToString();

    }
}
