using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WithdrawalNumberBtn : MonoBehaviour
{
    public void OnClickBtn()
    {
        string text = transform.Find("Text").GetComponent<Text>().text;
        int num = int.Parse(text.Replace(",",""));
        GameManager.instance.AccountDeposit(-num);
    }
}
