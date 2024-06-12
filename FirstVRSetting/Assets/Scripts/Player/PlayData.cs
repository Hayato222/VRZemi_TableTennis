using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayData : MonoBehaviour
{
    private float invadersCount = 25f;
    private float remaingInvaders = 25f;
    private float attackCount = 0f;
    [SerializeField]private float damage = 50f;
    [SerializeField] private float invaderPoint = 200f;

    /// <summary>
    /// 倒した敵の数×一匹当たりのポイントを返す
    /// </summary>
    /// <returns></returns>
    public float KillScore()
    {
        float score = 0f;
        return score = (invadersCount-remaingInvaders) * invaderPoint;
    }

    public void AddKill()
    {
        remaingInvaders--;
    }
    public float NumberAlive()
    {
        return remaingInvaders;
    }
    /// <summary>
    /// スルーした攻撃×ダメージを返す
    /// </summary>
    /// <returns></returns>
    public float DamageScore()
    {
        return attackCount * damage;
    }

    public void AddDamage()
    {
        attackCount++;
    }

    
    
}
