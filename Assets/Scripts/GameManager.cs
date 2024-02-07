using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text CashPanelText; // 현금 잔액 텍스트UI
    public Text AccountPanelText; // 통장 잔액 텍스트UI

    public GameObject DepositPanel; // 입금 UI
    public GameObject WithdrawalPanel; // 출금 UI
    public GameObject PopupPanel; // 팝업 화면
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 통장에 입금(출금시 음수를 매개변수로)
    public void AccountDeposit(int num)
    {
        int account = Convert.ToInt32(AccountPanelText.text.Replace(",", ""));
        int cash = Convert.ToInt32(CashPanelText.text.Replace(",", ""));
        if (num > 0 && (cash - num) < 0) // 입금시 잔액부족 조건
        {
            OpenPopupPanel();
        }
        else if (num < 0 && (account + num) < 0) // 출금이 잔액부족 조건
        {
            OpenPopupPanel();
        }
        else
        {
            AccountPanelText.text = $"{account + num:#,0}";
            CashPanelText.text = $"{cash - num:#,0}";
        }
    }

    public void OpenDepositPanel()
    {
        DepositPanel.SetActive(true);
    }
    public void CloseDepositPanel()
    {
        DepositPanel.SetActive(false);
    }
    public void OpenWithdrawalPanel()
    {
        WithdrawalPanel.SetActive(true);
    }
    public void CloseWithdrawalPanel()
    {
        WithdrawalPanel.SetActive(false);
    }
    public void OpenPopupPanel()
    {
        PopupPanel.SetActive(true);
    }
    public void ClosePopupPanel()
    {
        PopupPanel.SetActive(false);
    }
}
