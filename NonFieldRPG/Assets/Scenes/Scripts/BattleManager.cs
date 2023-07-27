using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. SceneManagement;

// �o�g�����Ǘ�����
// Player��Enemy���킹��
public class BattleManager : MonoBehaviour
{
    // Player���擾����
    public UnitManager player;
    // Enemy���擾����
    public UnitManager enemy;

    void Start()
    {
        player.Attack(enemy);
        enemy.Attack(player);
    }

    // �{�^�����N���b�N�����Ƃ��ɍU������
    public void OnClickAttackButton()
    {
        player.Attack(enemy);
        if (enemy.hp > 0)
        {
            EnemyTurn();
        } else
        {
            Debug.Log("GAME�I��");
            SceneManager.LoadScene("Main");
        }
    }

    void EnemyTurn()
    {
        enemy.Attack(player);
    }

}
