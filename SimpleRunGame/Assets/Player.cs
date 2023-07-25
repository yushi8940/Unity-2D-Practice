using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D rbody;

    public GameManager gameManager;

    public float speed = 10;
    public float jumpP = 300;

    private bool isJumping = false;
    private bool isFinished = false;

    // Start is called before the first frame update
    void Start()
    {
        rbody = this.gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (!isFinished)
        {
            if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
            {
                rbody.AddForce(transform.up * jumpP);
                isJumping = true;
            }
        }
        
    }

    private void FixedUpdate()
    {
        if (!isFinished)
        {
            rbody.velocity = new Vector2(speed, rbody.velocity.y);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "floor")
        {
            isJumping = false;
        }

        if (collision.gameObject.tag == "obstacle")
        {
            isFinished = true;
            gameManager.GameOver();
            Debug.Log("Game Over");
        }

        if (collision.gameObject.tag == "Finish")
        {
            isFinished = true;
            gameManager.GameClear();
            Debug.Log("Game Clear");
        }
    }
}
