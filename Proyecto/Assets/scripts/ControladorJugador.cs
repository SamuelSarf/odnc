using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public float velocidad = 6f;
    public Rigidbody rb;
    public Animator animator;
    Vector3 movimiento;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimiento.x = Input.GetAxisRaw("Horizontal");
        movimiento.z = Input.GetAxisRaw("Vertical");

        if (movimiento != Vector3.zero)
        {
            animator.SetFloat("horizontal", movimiento.x);
            animator.SetFloat("vertical", movimiento.z);
        }

        animator.SetFloat("moviendose", movimiento.sqrMagnitude);
    }




private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movimiento.normalized * velocidad * Time.fixedDeltaTime);
    }
}
