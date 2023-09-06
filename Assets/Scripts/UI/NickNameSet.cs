using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NickNameSet : MonoBehaviour
{
    [SerializeField]
    PlayerNickName playerNickName;
    [SerializeField]
    TextMeshProUGUI nickNameInputField;

    public void JoinButton()
    {
        playerNickName.SetNickName(nickNameInputField.text);
        this.gameObject.SetActive(false);
    }
}
