using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerNickName : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI nickNameTxt;
    [SerializeField]
    private Transform PlayerTr;
    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
        nickNameTxt = nickNameTxt.GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        this.transform.position = _camera.WorldToScreenPoint(PlayerTr.position) + new Vector3(0, 8f, 0);
    }

    public void SetNickName(string name)
    {
        PlayerPrefs.SetString("Name", name);
        nickNameTxt.text = PlayerPrefs.GetString("Name");
    }
}
