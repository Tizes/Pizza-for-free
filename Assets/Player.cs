using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;


public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float mv_speed = 5;
    // Start is called before the first frame update
    void FixedUpdate()
    {
        Move();

    }

    void ProcessInput()
    {
        float move_x = Input.GetAxisRaw("Horizontal");
        float move_y = Input.GetAxisRaw("Vertical");
        Vector2 MoveDirection = new Vector2(move_x, move_y);
    }

    void Move()
    {
        rb.velocity = new Vector2(MoveDirection.x * mv_speed, MoveDirection.y * mv_speed);
    }
    // Update is called once per frame
    void Update()
    {  
        ProcessInput();
        
    }
}
