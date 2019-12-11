using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 10f;
    public Rigidbody2D rb;
    public Animator animator1;
    Vector2 movement;
    // Update is called once per frame
    void Update()
    {
        //input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator1.SetFloat("Horizontal", movement.x);
        animator1.SetFloat("Vertical", movement.y);
        animator1.SetFloat("Speed", movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        //movement
        rb.MovePosition(rb.position+movement * moveSpeed * Time.fixedUnscaledDeltaTime);
    }
}
