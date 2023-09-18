using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    public float speed;
    private Vector2 moveInput;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PhysicsUpdate();
    }

    void PhysicsUpdate()
    {
        rb.MovePosition(rb.position + moveInput * speed * Time.fixedDeltaTime);
    }

    public void OnMove(InputValue value)
    {
        Debug.Log(value);
        // 'Move' code here.
        moveInput = value.Get<Vector2>();
        Debug.Log(moveInput);
    }
}
