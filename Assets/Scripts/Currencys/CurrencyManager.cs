using UnityEngine;

public class CurrencyManager : MonoBehaviour
{
    public static CurrencyManager instance;
    public static CurrencyManager Instance { get { return instance; } }


    [Header("References")]
    public GameObject coinMesh;

    [Header("Settings")]
    public int maxCountForCurrencys;

    [Header("Behaviour")]
    [HideInInspector] public int totalCurrencys;


    void Awake()
    {
        instance = this;
    }
    void Start() 
    {
        SaveData data = LoadSaveSystem.Load();
        if(data !=null)
            totalCurrencys = data.Money;
    }
    
    void Update() 
    {
        if(GameManager.Instance.endGame)
            LoadSaveSystem.Save(this);
    
    }

    public void AddCurrency(int valueToAdd)
    {
        totalCurrencys += valueToAdd;
    }
    public int GetCurrency()
    {
        return totalCurrencys;
    }
}
