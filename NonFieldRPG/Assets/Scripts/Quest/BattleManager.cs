using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Player‚ÆEnemy‚Ì‘Îí‚ÌŠÇ—
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


    // ‰Šúİ’è
    public void Setup(EnemyManager enemyManager)
    {
        enemyUI.gameObject.SetActive(true);

        enemy = enemyManager;
        playerUI.SetupUI(player);
        enemyUI.SetupUI(enemy);

        enemy.AddEventListenerOnTap(PlayerAttack);
    }

    // Player‚ªEnemy‚ÉUŒ‚
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


    // Enemy‚ªplayer‚ÉUŒ‚
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
