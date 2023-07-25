using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public Block[] blocks;
    public GameObject gameStartUI;
    public GameObject gameClearUI;
    public GameObject gameOverUI;
    public GameObject ball;
    public float ballSpeedX = 100;
    public float ballSpeedY = 100;

    private bool isGameCleared = false;

    private Rigidbody2D ballRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameCleared)
        {
            if (CheckAllBlocksDestroyed())
            {
                // Game Clear
                Debug.Log("Cleared");
                Destroy(ball);
                gameClearUI.SetActive(true);
                isGameCleared = true;
            }
        }
    }

    private bool CheckAllBlocksDestroyed()
    {
        foreach( Block block in blocks)
        {
            if (block != null)
            {
                return false;
            }
        }
        return true;
    }

    public void GameStart()
    {
        gameStartUI.SetActive(false);
        ballRigidbody = ball.gameObject.GetComponent<Rigidbody2D>();

        Vector2 force = new Vector2(ballSpeedX, ballSpeedY);

       ballRigidbody.AddForce(force);
    }

    public void GameOver()
    {
        Debug.Log("GameOver");
        gameOverUI.SetActive(true);
    }

    public void GameRetry()
    {
        SceneManager.LoadScene("game");
    }

}
