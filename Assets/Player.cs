using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    
    private Rigidbody rb;
    private Animator animator;

    private bool isDead;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //.GetAxis = Vai de zero a menos um ou mais um de maneira suave.
        //.GetAxisRaw = vai de zero a menos um ou mais um de maneira abrupta.

        if(isDead)
            return;

        float horizontal = Input.GetAxis("Horizontal"); //Seta da esquerda(ou tecla A) resulta num valor negativo, já a seta da direita(ou tecla D) resultado em positivo.
        float vertical = Input.GetAxis("Vertical"); //Seta para cima(ou tecla W) resulta num valor positivo, já a seta para baixo(ou tecla S) resulta em negativo.

        if(horizontal != 0 || vertical != 0)
        {
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }

        Vector3 movement = new Vector3(horizontal, 0 , vertical);

        if(movement != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(movement);

        //rb.AddForce(movement * speed);
    }

    void Death()
    {
        isDead = true;
        animator.SetTrigger("Death");
    }
}
