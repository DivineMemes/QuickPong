using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public float speed;
    public struct Scores
    {
        public int P1Score;
        public int P2Score;

        public bool scored;
    }
    public static Scores score;


    public struct GameTime
    {
        public float timer;
        public float Start;
        public bool GameOver;
    }

    public static GameTime runtime;

    public GameObject ball;

    void Start()
    {
        // ball = GameObject.FindGameObjectWithTag("Ball");
        //GameObject clonedball = Instantiate(ball, Vector3.zero, Quaternion.identity);
        //Rigidbody2D clonerb = clonedball.GetComponent<Rigidbody2D>();
        //clonerb.AddForce((Random.insideUnitCircle) * speed);
        BallScript.ball.readyToSpawn = true;
    }
    void Update()
    {
        if (runtime.GameOver != true)
        {
            if (score.scored == true)
            {
                runtime.timer += Time.deltaTime;
                if (runtime.timer >= runtime.Start)
                {
                    BallScript.ball.readyToSpawn = true;
                    runtime.timer = 0;
                    score.scored = false;
                }
            }

        }
        if(score.P1Score >= 7)
        {
            runtime.GameOver = true;
        }
        if(score.P2Score >= 7)
        {
            runtime.GameOver = true;
        }

        
        


    }


}

