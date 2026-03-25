using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    public InputAction moveAction;
    Rigidbody2D rigidbody2D;
    public int maxHealth = 5;
    public int health { get { return currentHealth; }}
    int currentHealth;
    Vector2 move;
    public float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        moveAction.Enable();
        rigidbody2D = GetComponent<Rigidbody2D>();
        // currentHealth = maxHealth;
    }


    // Update is called once per frame
    void Update()
    {
        move = moveAction.ReadValue<Vector2>();
        // Debug.Log("Object that entered the trigger: " + other);
    }
    void FixedUpdate()
    {
        Vector2 position = (Vector2)transform.position + move * speed * Time.fixedDeltaTime;
        rigidbody2D.MovePosition(position);
    }
    public void changeHealth(int amount = 1)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}