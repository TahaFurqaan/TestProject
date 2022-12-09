using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> items = new List<GameObject>();
    public int[] nums = new int[10];

    Wizard w = new Wizard();

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("CallAfterDelay");
        Debug.Log("The energy is " + w.energy);
    }

    IEnumerator CallAfterDelay()
    {
        yield return new WaitForSeconds(3f);
        Wizard.WizardFunc();
        Debug.Log("The power is " + Wizard.power);
    }




    
}