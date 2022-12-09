using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Player
{
    public static int power = 100;
    public float energy = 10f;
    public delegate void PlayerDied();
    public static event PlayerDied playerDied;

    void Start()
    {
        if (playerDied != null)
        {
            playerDied();
        }
    }

    public Wizard()
    {

    }
    public Wizard(string name, float health)
    {
        this.Name = name;
        this.Health = health;
    }
    public static void WizardFunc()
    {
        Debug.Log("The Wizard Function is static");
    }
    public void WizardInfo()
    {
        Debug.Log("This is from Wizard class");
    }
    public override void Attack()
    {
        Debug.Log("The Wizard is Attacking");
    }




}
