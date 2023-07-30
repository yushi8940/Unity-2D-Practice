using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int hp;
    public int atk;

    // UŒ‚‚ğ‚·‚é
    public void Attack(EnemyManager enemy)
    {
        enemy.Damage(atk);
    }

    // ƒ_ƒ[ƒW‚ğó‚¯‚é
    public void Damage(int damage)
    {
        hp -= damage;
        if (hp < 0)
        {
            hp = 0;
        }
        Debug.Log("player‚Ì‘Ì—Í‚Í" + hp);
    }

}
