using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelection : MonoBehaviour
{
    [SerializeField]
    SecondaryCannonType SelectedCannon;
    [SerializeField]
    DroneType SelectedDrone;
    [SerializeField]
    SpecialType SelectedSpecial;
    
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Data");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
    public void SetCannonType(int cannon)
    {
        if (cannon == 0)
            SelectedCannon = SecondaryCannonType.Angle0;
        
        if (cannon == 1)
            SelectedCannon = SecondaryCannonType.Angle30;
        
        if (cannon == 2)
            SelectedCannon = SecondaryCannonType.Angle75;
        
        if (cannon == 3)
            SelectedCannon = SecondaryCannonType.Angle120;
        
        if (cannon == 4)
            SelectedCannon = SecondaryCannonType.none;

    }
    public void SetDroneType(int drone)
    {
        if ( drone == 0)
            SelectedDrone = DroneType.Attack;

        if (drone == 1)
            SelectedDrone = DroneType.Magnetic;
        
        if (drone == 2)
            SelectedDrone = DroneType.Healer;
        
        if ( drone == 3)
            SelectedDrone = DroneType.Rocket;

        if (drone == 4)
            SelectedDrone = DroneType.none;

    }
    public void SetSpecialType(int special)
    {
        if (special == 0)
            SelectedSpecial = SpecialType.BOMB;
        
        if (special == 1)
            SelectedSpecial = SpecialType.LAZER;
        
        if (special == 2)
            SelectedSpecial = SpecialType.FIRE;
        
    }
    public SecondaryCannonType GetCannonType()
    {
        return SelectedCannon;
    }
    public DroneType GetDroneType()
    {
        return SelectedDrone;
    }
    public SpecialType GetSpecialType()
    {
        return SelectedSpecial;
    }


    public string GetStringCannonType()
    {
        return System.Enum.GetName(typeof(SecondaryCannonType), SelectedCannon);
    }

    public string GetStringDroneType()
    {
        return System.Enum.GetName(typeof(DroneType), SelectedDrone);
    }

    public string GetStringSpecialType()
    {
        return System.Enum.GetName(typeof(SpecialType), SelectedSpecial);
    }

}
