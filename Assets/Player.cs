using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;


public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform tp;
    public GameObject cam;
    public GameObject car;
    public float mv_speed = 5;
    Vector3[] VecArr = { new Vector3(13, -193, 3), new Vector3(-18, -225, 3), new Vector3(53, -203, 3), };
    
    Vector2 MoveDirection;
    // Start is called before the first frame update
    void Start()
    {
            int randInt = Random.Range(0, VecArr.Length - 1);
            car.transform.position = VecArr[randInt];

        // Find the main camera by tag
        /*GameObject cam = GameObject.FindWithTag("MainCamera");
        GameObject car = GameObject.FindWithTag("Player");*/
    }
    private void Awake()
    {
            tp.position = new Vector3(car.transform.position.x, car.transform.position.y, -20);
            cam.transform.position = new Vector3(car.transform.position.x, car.transform.position.y, -20);
            rb.position = new Vector3(car.transform.position.x, car.transform.position.y, -20);
    }

    void FixedUpdate()
    {   
        Move();
    }

    void ProcessInput()
    {
        float move_x = Input.GetAxisRaw("Horizontal");
        float move_y = Input.GetAxisRaw("Vertical");
        MoveDirection = new Vector2(move_x, move_y);
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
