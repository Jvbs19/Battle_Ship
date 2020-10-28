using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCoins : MonoBehaviour
{
    [SerializeField]
    Text coins;

    void Update()
    {
        coins.text = "" + CurrencyManager.instance.totalCurrencys;
    }
}
