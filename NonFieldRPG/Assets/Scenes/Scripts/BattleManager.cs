using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. SceneManagement;

// バトルを管理する
// PlayerとEnemyを戦わせる
public class BattleManager : MonoBehaviour
{
    // Playerを取得する
    public UnitManager player;
    // Enemyを取得する
    public UnitManager enemy;

    void Start()
    {
        player.Attack(enemy);
        enemy.Attack(player);
    }

    // ボタンをクリックしたときに攻撃する
    public void OnClickAttackButton()
    {
        player.Attack(enemy);
        if (enemy.hp > 0)
        {
            EnemyTurn();
        } else
        {
            Debug.Log("GAME終了");
            SceneManager.LoadScene("Main");
        }
    }

    void EnemyTurn()
    {
        enemy.Attack(player);
    }

}
