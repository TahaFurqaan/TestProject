using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float health = 100f;
    private string name = "Wizard";

    public Player()
    {


    }

    //using constructor and parameters
    public Player(string name,float health)
    {
        this.name = name;
        this.health = health;
    }
    public float Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public virtual void Attack()
    {
        Debug.Log("Enemy Is Frozen and Enemy is Attacking");
    }
    public void Hero()
    {
        Debug.Log("The Hero is Attacking");
    }
    public void Enemy()
    {
        Debug.Log("Now Enemy is attacking");
    }
    public void PlayerInfo()
    {
        Debug.Log("The Player name is:" + name + "The Player health is:" + health);
    }
}