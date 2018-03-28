using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2 : MonoBehaviour
{
    public struct PaddleTwo
    {
        public Vector3 position;

        public Rigidbody2D rb;
        public float speed;
    }
    public static PaddleTwo paddle2;
    public float speed;
    void Start()
    {
        paddle2.rb = gameObject.GetComponent<Rigidbody2D>();
        paddle2.speed = speed;
    }
    Vector3 temp;

    void Update()
    {
        Controller2();
        paddle2.position = gameObject.transform.position;
    }

    void Controller2()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            paddle2.rb.AddForce(new Vector2(0, 5) * paddle2.speed);
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            paddle2.rb.velocity = new Vector2(0, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            paddle2.rb.AddForce(new Vector2(0, -5) * paddle2.speed);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            paddle2.rb.velocity = new Vector2(0, 0);
        }

        temp = paddle2.position;
        temp.y = Mathf.Clamp(paddle2.position.y, -4.3f, 4.3f);
    }
}
 