using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Player��Enemy�̑ΐ�̊Ǘ�
public class BattleManager : MonoBehaviour
{
    public QuestManager questManager;
    public PlayerUIManager playerUI;
    public PlayerManager player;
    public EnemyUIManager enemyUI;
    EnemyManager enemy;

    private void Start()
    {
        enemyUI.gameObject.SetActive(false);
    }


    // �����ݒ�
    public void Setup(EnemyManager enemyManager)
    {
        enemyUI.gameObject.SetActive(true);

        enemy = enemyManager;
        playerUI.SetupUI(player);
        enemyUI.SetupUI(enemy);

        enemy.AddEventListenerOnTap(PlayerAttack);
    }

    // Player��Enemy�ɍU��
    void PlayerAttack()
    {
        player.Attack(enemy);
        enemyUI.UpdateUI(enemy);
        if (enemy.hp <= 0)
        {
            Destroy(enemy.gameObject);
            EndBattle();
        } else
        {
            EnemyTurn();
        }
    }


    // Enemy��player�ɍU��
    void EnemyTurn()
    {
        enemy.Attack(player);
        playerUI.UpdateUI(player);
    }

    void EndBattle()
    {
        enemyUI.gameObject.SetActive(false);
        Debug.Log("Battle END");
        questManager.EndBattle();
    }

}
