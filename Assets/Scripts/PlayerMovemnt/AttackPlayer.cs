using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    private Animator anim;
    private bool endAttack = false;

    private int attackCount = 0;
    private int maxAttackCount = 3;
  


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Inicia el ataque y activa la animación
            Attack();
        }
      
    }

    void Attack()
    { 

        // Activa la condición booleana "Attack" en el anim
        anim.SetTrigger("Attack");
        endAttack = true;

   
    }

    


}
