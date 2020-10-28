using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadCoinsMenu : MonoBehaviour
{
    [SerializeField]
    Text coinsCount;
    int coins =0;

    void Start()
    {
        SaveData data = LoadSaveSystem.Load();
        if(data !=null)
            coins = data.Money;
    }

    
    void Update()
    {
        coinsCount.text = ""+coins;
    }
}
