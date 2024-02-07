using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WithdrawalUserInput : MonoBehaviour
{
    public InputField field;
    public void OnClickUserInput()
    {
        int num = int.Parse(field.text);
        if (num > 0)
        {
            GameManager.instance.AccountDeposit(-num);
        }
    }
}
