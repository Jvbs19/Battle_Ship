using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData
{
    public int Money;

    public SaveData(CurrencyManager currency)
    {
        Money = currency.GetCurrency();
    }
    
}
