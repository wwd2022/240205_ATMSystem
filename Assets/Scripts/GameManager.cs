using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text CashPanelText; // ���� �ܾ� �ؽ�ƮUI
    public Text AccountPanelText; // ���� �ܾ� �ؽ�ƮUI

    public GameObject DepositPanel; // �Ա� UI
    public GameObject WithdrawalPanel; // ��� UI
    public GameObject PopupPanel; // �˾� ȭ��
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

    // ���忡 �Ա�(��ݽ� ������ �Ű�������)
    public void AccountDeposit(int num)
    {
        int account = Convert.ToInt32(AccountPanelText.text.Replace(",", ""));
        int cash = Convert.ToInt32(CashPanelText.text.Replace(",", ""));
        if (num > 0 && (cash - num) < 0) // �Աݽ� �ܾ׺��� ����
        {
            OpenPopupPanel();
        }
        else if (num < 0 && (account + num) < 0) // ����� �ܾ׺��� ����
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
