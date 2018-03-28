using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    public struct Ball
    {
        public float speed;
        public float multiplier;
        public bool readyToSpawn;
        public float velSign;
        //public Vector2 position;
        public Rigidbody2D rb;
    }
    public static Ball ball;
    public float speed;
    public GameObject Theball;
    public float multiplyer;
    void Start ()
    {
        
        ball.rb = gameObject.GetComponent<Rigidbody2D>();
        ball.speed = speed;
        ball.multiplier = multiplyer;
       // Random.insideUnitCircle;
    }


    void Update()
    {
        if (ball.readyToSpawn)
        {
            GameObject clonedball = Instantiate(Theball, Vector3.zero, Quaternion.identity);
            Rigidbody2D clonerb = clonedball.GetComponent<Rigidbody2D>();
            clonerb.AddForce((Random.insideUnitCircle)* ball.speed, ForceMode2D.Impulse);
            ball.readyToSpawn = false;
        }


        if(gameObject!=null)
        {

            ball.velSign = Mathf.Sign(ball.rb.velocity.x);
        

        if(Mathf.Abs(ball.rb.velocity.x) < 2)
        {
            ball.rb.AddForce(new Vector2(2, 0)*ball.velSign);
        }
    }
 }

    void OnCollisionEnter2D(Collision2D other)
    {

        ball.speed *= ball.multiplier;
        //ball.rb.velocity *= -1;
       // ball.rb.AddForce(ball.rb.velocity.normalized, ForceMode2D.Impulse);

        if(other.collider.name == "P1scorebox")
        {
            gameManager.score.P1Score++;
            gameManager.score.scored = true;
            Destroy(gameObject);
        }


        if(other.collider.name == "P2scorebox")
        {
            gameManager.score.P2Score++;
            gameManager.score.scored = true;
            Destroy(gameObject);
        }




        
    }
}
