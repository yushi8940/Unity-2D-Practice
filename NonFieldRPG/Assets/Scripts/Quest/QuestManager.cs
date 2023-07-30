using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// �N�G�X�g�S�̂��Ǘ�
public class QuestManager : MonoBehaviour
{
    public StageUIManager stageUI;
    public GameObject enemyPrefab;
    public BattleManager battleManager;
    public SceneTransitionManager sceneTransitionManager;


    // �G�ɑ�������e�[�u�� : -1�Ȃ瑘�����Ȃ�, 0�Ȃ瑘��
    int[] encountTable = { -1, -1, 0, -1, -0, -1 };

    private int currentStage = 0;

    private void Start()
    {
        stageUI.UpdateUI(currentStage);
    }

    // NextButton�������ɐi�s�x��i�߂�
    public void onNextButton()
    {
        currentStage ++;
        // �i�s�x��UI�ɔ��f
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
        // �N�G�X�g�N���A�ƕ\������
        stageUI.StageClear();
        // sceneTransitionManager.LoadTo("Town");
    }
}
