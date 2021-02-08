using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightGoal : MonoBehaviour
{
    public ScoreTotal st;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Ball"))
        {
            st.increasePlayer1Score();
            Debug.Log("Player 1 Scored!");
            Debug.Log($"Score:\nPlayer 1: {st.getPlayer1Score()} \nPlayer 2: {st.getPlayer2Score()}");
        }
    }
}
