using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private Rigidbody2D rBody;
    public GameManager gameManager;

    private bool isOnWall = true;

    public float speed;
    public float jumpPower;

    private const string TAG_WALL = "Wall";
    private const string TAG_OBSTACLE = "Obstacle";
    private const string TAG_FINISH = "Finish";


    void Start()
    {
        rBody = this.gameObject.GetComponent<Rigidbody2D>();
        Vector2 force = new Vector2(speed, 0f);
        rBody.AddForce(force);
    }

    void Update()
    {
        // Switch gravity upside-down
        if (Input.GetKeyDown(KeyCode.Space) && isOnWall)
        {
            // Disable jumping when player is off the wall
            isOnWall = false;
            Vector2 jumpForce = new Vector2(0f, jumpPower);
            rBody.AddForce(jumpForce);
            jumpPower *= -1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Enable jumping when player is on the wall
        if (collision.gameObject.tag == "Wall")
        {
        }


        if (collision.gameObject.tag == "Obstacle")
        {
        }

        switch (collision.gameObject.tag)
        {
            case TAG_WALL:
                isOnWall = true;
                break;

            case TAG_OBSTACLE:
                StopPlayer();
                gameManager.GameOver();
                break;

            case TAG_FINISH:
                StopPlayer();
                gameManager.GameClear();
                break;
        }
    }

    private void StopPlayer()
    {
        rBody.velocity = Vector2.zero;
        this.gameObject.SetActive(false);
    }

}
