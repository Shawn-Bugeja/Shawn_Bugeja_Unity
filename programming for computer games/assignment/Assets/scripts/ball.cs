using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
    private paddle myPaddle;

    private Vector3 paddleToBallVector;

    private bool hasStarted = false;

    float randomX, randomY;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "walltop" || collision.gameObject.name == "wallBottom")
        {
            //when collides with a wall or object the random number is changed so that the direction of the ball always changes
            randomX = Random.Range(-0.2f, 0f);
            Vector2 tweak = new Vector2(randomY, randomX);
            this.GetComponent<Rigidbody2D>().velocity += tweak;
        }
        else
        { 
            Vector2 tweak = new Vector2(randomY, randomX);
            this.GetComponent<Rigidbody2D>().velocity += tweak;
        }

        if (collision.gameObject.name == "wallright" || collision.gameObject.name == "wallleft")
        {
            Destroy(this.gameObject);
            print("k");
        }

    }

    // Use this for initialization
    void Start()
    {
        randomX = Random.Range(0f, 0.2f);
        randomY = Random.Range(0f, 0.2f);

        myPaddle = GameObject.FindObjectOfType<paddle>();

        paddleToBallVector = this.transform.position - myPaddle.transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        if (!hasStarted) // if hasStarted == false 
        {
            this.transform.position = myPaddle.transform.position + paddleToBallVector;

            if (Input.GetMouseButtonDown(0))
            {
                hasStarted = true;

                this.GetComponent<Rigidbody2D>().velocity = new Vector2(20f, 1f);
            }
        }

    }
}
