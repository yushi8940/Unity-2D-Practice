using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// キャラクターを管理する
public class UnitManager : MonoBehaviour
{

    // ステータス
    public int hp;
    public int at;

    // 攻撃関数
    public void Attack(UnitManager target)
    {
        target.Damage(at);
    }

    // ダメージ関数
    void Damage(int damage)
    {
        hp -= damage;
        Debug.Log(name + "はダメージを受けた");
        if (hp < 0)
        {
            hp = 0;
        }
        Debug.Log(name + "の残りHPは" + hp);
    }

}
