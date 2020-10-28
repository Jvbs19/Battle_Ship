using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBehaviour : MonoBehaviour
{
    [Header("Player Status")]
    [SerializeField]
    ShipController PlayerShip;
    [SerializeField]
    Image LifeBar;
    float Maxlife, life;

    [Header("Currency")]
    [SerializeField]
    Text CoinTxt;

    [Header("GameOver")]
    [SerializeField]
    GameObject GameOverScreen;


    void Start()
    {
        Maxlife = PlayerShip.GetHealth();
    }

    void Update()
    {
        if(GameManager.Instance.endGame)
        {
            GameOver(true);
        }
        else
        {
            UpdateHealth();
            UpdateLifeBar();
            UpdateCoins();
        }
    }
    #region Health
    void UpdateHealth()
    {
        life = PlayerShip.GetHealth();
    }
    void UpdateLifeBar()
    {
        if(LifeBar!= null)
        LifeBar.fillAmount = life / Maxlife;
    }
    #endregion
    void UpdateCoins()
    {
        CoinTxt.text = "" + CurrencyManager.Instance.GetCurrency();
    }
    public void GameOver(bool g)
    {
        GameOverScreen.SetActive(g);
    }
}
