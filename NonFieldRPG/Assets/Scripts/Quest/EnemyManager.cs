using System;
using UnityEngine;

// 敵の管理(ステータス/クリック検知)
public class EnemyManager : MonoBehaviour
{

    // 関数登録
    Action tapAction; // クリックされたときに実行したい関数（外部から設定したい）

    public new string name;
    public int hp;
    public int atk;

    public void Attack(PlayerManager player)
    {
        player.Damage(atk);
    }

    public void Damage(int damage)
    {
        hp -= damage;
        if (hp < 0)
        {
            hp = 0;
        }
        Debug.Log("enemyの体力は" + hp);
    }

    public void OnTap()
    {
        Debug.Log("Clicked");
        tapAction();
    }

    // tapActionに関数を登録する関数を作る
    public void AddEventListenerOnTap(Action action)
    {
        tapAction += action;
    }
}
