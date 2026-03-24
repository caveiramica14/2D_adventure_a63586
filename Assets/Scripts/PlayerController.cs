using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerControllerTutorialUpdates : MonoBehaviour
{
    public InputAction moveAction;
    Rigidbody2D rigidbody2D;
    public int maxHealth = 5;
    int currentHealth;
    Vector2 move;
    public float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        moveAction.Enable();
        currentHealth = maxHealth;
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
        Vector2 position = (Vector2)transform.position + move * speed * Time.fixedDeltaTime;
        rigidbody2D.MovePosition(position);
    }
    void changeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}