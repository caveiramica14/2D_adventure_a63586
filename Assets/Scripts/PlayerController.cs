using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerControllerTutorialUpdates : MonoBehaviour
{
    public InputAction moveAction;
    Rigidbody2D rigidbody2D;
    Vector2 move;   
    // Start is called before the first frame update
    void Start()
    {
        moveAction.Enable();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        move = moveAction.ReadValue<Vector2>();
        Debug.Log(move);
    }
    void FixedUpdate()
    {
        Vector2 position = (Vector2)transform.position + move * 3.0f * Time.fixedDeltaTime;
        rigidbody2D.MovePosition(position);
    }
}