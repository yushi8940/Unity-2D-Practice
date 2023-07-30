using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIManager : MonoBehaviour
{
    public Text hpText;
    public Text atkText;

    public void SetupUI(PlayerManager player)
    {
        hpText.text = string.Format("HP   : {0}", player.hp);
        atkText.text = string.Format("ATK : {0}", player.atk);
    }

    public void UpdateUI(PlayerManager player)
    {
        hpText.text = string.Format("HP  : {0}", player.hp);
    }
}
