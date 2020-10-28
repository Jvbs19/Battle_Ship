using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    
    [Header("Time Settings")]
    [SerializeField] 
    float MaxTimer = 120f;
    float Timer;
    bool pauseTimer = false;

    [SerializeField]
    Text TimerTXT;

    bool TimeOver = false;
    void Start()
    {
        ResetTimer();
    }

    void Update()
    {
        TimerOut();
    }
    void FixedUpdate()
    {
        TimerControl();
    }

    #region TimerSettings
    void TimerOut()
    {
        if (Timer <= 0)
        {
            TimeOver = true;
            GameManager.Instance.EndGame();
        }
    }
    void TimerControl()
    {
        if (Timer > 0 && pauseTimer == false)
        {
            TimerTXT.text = ""+(int)Timer;
            Timer -= Time.deltaTime;
        }
    }

    public void ResetTimer()
    {
        Timer = MaxTimer;
    }
    public void SetMaxTimer(float time)
    {
        MaxTimer = time;
    }
    void ForcedTimeOut()
    {
        Timer = 0;
    }

    void SetTimerStatus(bool time)
    {
        pauseTimer = time;
    }
    public bool GetTimerStatus()
    {
        return pauseTimer;
    }
    public bool IsTimerOver()
    {
        return TimeOver;
    }
    #endregion
}
