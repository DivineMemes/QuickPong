using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle1 : MonoBehaviour
{
    public struct PaddleOne
    {
        public Vector3 position;

        public Rigidbody2D rb;
        public float speed;
    }
    public static PaddleOne paddle1;
    public float speed;
    public Vector3 temp;

    void Start ()
    {
        //paddle1.scored = false;
        paddle1.rb = gameObject.GetComponent<Rigidbody2D>();
        paddle1.speed = speed;

	}
	void Update ()
    {
        Controller1();
        paddle1.position = gameObject.transform.position;
    }

    void Controller1()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            paddle1.rb.AddForce(new Vector2(0, 5)*paddle1.speed);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            paddle1.rb.velocity = new Vector2(0, 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            paddle1.rb.AddForce(new Vector2(0, -5)*paddle1.speed);
        }
        else if(Input.GetKeyUp(KeyCode.S))
        {
            paddle1.rb.velocity = new Vector2(0, 0);
        }
        temp = paddle1.position;
        temp.y = Mathf.Clamp(paddle1.position.y, -4.3f, 4.3f);
        
    }

}
