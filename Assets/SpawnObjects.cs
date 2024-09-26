using System.Collections;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public Camera Cam;
    public GameObject[] cubePrefab; // Reference to the cube prefab
    public GameObject objectToDisable;
    public int number;
    public float delay = 1.0f; // Delay in seconds before turning bool to true
    private bool canSpawn = true; // Flag to control spawning
    private float nextSpawnTime = 0f; // Time when next spawn is allowed

    /*private void Update()
    {
        // Check if it's time to allow spawning again
        if (!canSpawn && Time.time >= nextSpawnTime)
        {
            canSpawn = true; // Enable spawning
            objectToDisable.SetActive(true); // Enable the object
        }

        // Check for mouse button click and if spawning is allowed
        if (Input.GetMouseButtonDown(0) && canSpawn)
        {
    }*/
    private void Update()
    {
        // Check for mouse button click
        if (Input.GetMouseButtonDown(0) )
        {
            // Disable the object
           

            // Get the mouse position in screen space
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = -Camera.main.transform.position.z;

            // Convert the mouse position from screen space to world space
            Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            spawnPosition.z = 0f;

            // Spawn the cube at the mouse position
            Instantiate(cubePrefab[number], spawnPosition, Quaternion.identity);


            // Calculate the next spawn time
        

            // Disable spawning until the next spawn time
         
        }
    }
} 

