using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gameUI;
    public SceneChanger sceneChanger;

    public Text uiText;

    private const string GAMEOVER_MSG = ".. GAME OVER ..";
    private const string GAMECLEAR_MSG = "\\\\ GAME CLEAR //";


    private void Start()
    {
        gameUI.SetActive(false);
    }

    public void LoadScene(string sceneName)
    {
        sceneChanger.LoadTo(sceneName);
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        uiText.text = GAMEOVER_MSG;
        uiText.color = new Color(1f, 0f, 0f, 1f);
        gameUI.SetActive(true);
    }

    public void GameClear()
    {
        Debug.Log("Game Clear");
        uiText.text = GAMECLEAR_MSG;
        uiText.color = new Color(0f, 1f, 1f, 1f);
        gameUI.SetActive(true);
    }

}
