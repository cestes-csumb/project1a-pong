using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour

{
    public PaddleLeft paddleLeft;
    public PaddleRight paddleRight;
    public int paddleLimitFactor = 30;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Input Manager Loaded.");   
    }

    // Update is called once per frame
    void Update()
    {
        //Player 1/Paddle Left
        if (Input.GetAxis("player1") != 0)
        {
            paddleLeft.transform.Translate(Vector3.forward * Input.GetAxis("player1") / paddleLimitFactor, Space.World);
        }
        //Player 2/Paddle Right
        
        if (Input.GetAxis("player2") != 0)
        {
            paddleRight.transform.Translate(Vector3.forward * Input.GetAxis("player2") / paddleLimitFactor, Space.World);
        }

    }
}
