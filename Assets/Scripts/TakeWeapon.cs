using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeWeapon : MonoBehaviour
{
    [SerializeField] public GameObject[] weapon;
    [SerializeField] public GameObject[] shield;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateWeapon(int number)
    {
        for (int i = 0; i < weapon.Length; i++) 
        {
            weapon[i].SetActive(i == number);
        }
    }

    public void ActivateShield(int number)
    {
        for (int i = 0; i < shield.Length; i++)
        {
            shield[i].SetActive(i == number);
        }
    }
}
