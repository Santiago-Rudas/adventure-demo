using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateShield : MonoBehaviour
{
    public TakeWeapon takeWeapon;
    public int numberWeapon;

    // Start is called before the first frame update
    void Start()
    {
        takeWeapon = GameObject.FindGameObjectWithTag("Player").GetComponent<TakeWeapon>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            takeWeapon.ActivateWeapon(numberWeapon);
        }
    }
}
