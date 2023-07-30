using System;
using UnityEngine;

// �G�̊Ǘ�(�X�e�[�^�X/�N���b�N���m)
public class EnemyManager : MonoBehaviour
{

    // �֐��o�^
    Action tapAction; // �N���b�N���ꂽ�Ƃ��Ɏ��s�������֐��i�O������ݒ肵�����j

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
        Debug.Log("enemy�̗̑͂�" + hp);
    }

    public void OnTap()
    {
        Debug.Log("Clicked");
        tapAction();
    }

    // tapAction�Ɋ֐���o�^����֐������
    public void AddEventListenerOnTap(Action action)
    {
        tapAction += action;
    }
}
