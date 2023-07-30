using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// StagaUIを管理(ステージ数のUI/進行ボタン/街に戻るボタン)の管理
public class StageUIManager : MonoBehaviour
{
    public Text stageText;
    public GameObject nextButton;
    public GameObject goBackButton;
    public GameObject clearText;


    public void UpdateUI(int currentStage)
    {
        stageText.text = string.Format("Stage : {0}", currentStage + 1);
    }

    public void ShowButtons(bool isTrue)
    {
        nextButton.SetActive(isTrue);
        goBackButton.SetActive(isTrue);
    }

    public void StageClear()
    {
        clearText.SetActive(true);
        nextButton.SetActive(false);
        goBackButton.SetActive(true);
    }

}
