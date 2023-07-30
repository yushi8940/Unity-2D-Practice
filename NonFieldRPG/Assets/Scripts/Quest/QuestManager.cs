using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// クエスト全体を管理
public class QuestManager : MonoBehaviour
{
    public StageUIManager stageUI;
    public GameObject enemyPrefab;
    public BattleManager battleManager;
    public SceneTransitionManager sceneTransitionManager;


    // 敵に遭遇するテーブル : -1なら遭遇しない, 0なら遭遇
    int[] encountTable = { -1, -1, 0, -1, -0, -1 };

    private int currentStage = 0;

    private void Start()
    {
        stageUI.UpdateUI(currentStage);
    }

    // NextButton押下時に進行度を進める
    public void onNextButton()
    {
        currentStage ++;
        // 進行度をUIに反映
        stageUI.UpdateUI(currentStage);

        if (encountTable.Length <= currentStage)
        {
            QuestClear();
        } else if (encountTable[currentStage] == 0)
        {
            Debug.Log("Encount Enemy");
            EncountEnemy();
        }

    }

    void EncountEnemy()
    {
        stageUI.ShowButtons(false);
        GameObject enemyObj = Instantiate(enemyPrefab);
        EnemyManager enemy = enemyObj.GetComponent<EnemyManager>();
        battleManager.Setup(enemy);
    }

    public void EndBattle()
    {
        stageUI.ShowButtons(true);
    }

    void QuestClear()
    {
        // クエストクリアと表示する
        stageUI.StageClear();
        // sceneTransitionManager.LoadTo("Town");
    }
}
