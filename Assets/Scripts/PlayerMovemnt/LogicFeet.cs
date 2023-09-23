using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicFeet : MonoBehaviour
{
    public PlayerMoveLogic playerLogic;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        playerLogic.canJump = true;
    }

    private void OnTriggerExit(Collider other)
    {
        playerLogic.canJump = false;
    }
}
