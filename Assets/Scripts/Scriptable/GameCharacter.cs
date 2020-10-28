using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Char", menuName = "Char")]
public class GameCharacter : ScriptableObject
{
    public enum Type { Hero, Enemy};

    [SerializeField] 
    string Name;
    [SerializeField] 
    Type MyType;
    [SerializeField] 
    int Health;
    [SerializeField] 
    float Speed;
    [SerializeField] 
    int Attack;
    
    [SerializeField] 
    float FireDamage;
    [SerializeField] 
    float BulletRecharge;
    [SerializeField] 
    float ShieldResistence;
    [SerializeField] 
    float MeleeDamage;
    [SerializeField] 
    float FireRate;
    [SerializeField] 
    float FireRecharge;
    [SerializeField] 
    float ShieldRecharge;
    [SerializeField] 
    float MeleeDelay;
    [SerializeField] 
    float MeleeTime;
    [SerializeField] 
    float StunTime;
    public string GetName()
    {
        return Name;
    }
    public string GetMyType()
    {
        return System.Enum.GetName(typeof(Type), MyType);
    }
    public int GetAttack()
    {
        return Attack;
    }
    public int GetHealth()
    {
        return Health;
    }
    public float GetSpeed()
    {
        return Speed;
    }
    public float GetFireDamage()
    {
        return FireDamage;
    }
    public float GetBulletRecharge()
    {
        return BulletRecharge;
    }
    public float GetShieldResistence()
    {
        return ShieldResistence;
    }
    public float GetMeleeDamage()
    {
        return MeleeDamage;
    }
    public float GetFireRate()
    {
        return FireRate;
    }
    public float GetFireRecharge()
    {
        return FireRecharge;
    }
    public float GetShieldRecharge()
    {
        return ShieldRecharge;
    }
    public float GetMeleeDelay()
    {
        return MeleeDelay;
    }
    public float GetMeleeTime()
    {
        return MeleeTime;
    }
    public float GetStunTime()
    {
        return  StunTime;
    }

}
