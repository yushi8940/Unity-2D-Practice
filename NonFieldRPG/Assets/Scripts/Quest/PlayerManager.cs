using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int hp;
    public int atk;

    // �U��������
    public void Attack(EnemyManager enemy)
    {
        enemy.Damage(atk);
    }

    // �_���[�W���󂯂�
    public void Damage(int damage)
    {
        hp -= damage;
        if (hp < 0)
        {
            hp = 0;
        }
        Debug.Log("player�̗̑͂�" + hp);
    }

}
