<<<<<<< Updated upstream
=======
using System.Collections;
>>>>>>> Stashed changes
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject[] cubePrefab; // Reference to the cube prefab
    public GameObject objectToDisable;
    public int number;
    public float delay = 1.0f; // Delay in seconds before turning bool to true
    private bool canSpawn = true; // Flag to control spawning
<<<<<<< Updated upstream
    private float nextSpawnTime = 0f; // Time when next spawn is allowed

    private void Update()
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
=======

    private void Update()
    {
        // Check for mouse button click
        if (Input.GetMouseButtonDown(0) && canSpawn)
        {
>>>>>>> Stashed changes
            // Disable the object
            objectToDisable.SetActive(false);

            // Get the mouse position in screen space
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = -Camera.main.transform.position.z;

            // Convert the mouse position from screen space to world space
            Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            spawnPosition.z = 0f;

            // Spawn the cube at the mouse position
            Instantiate(cubePrefab[number], spawnPosition, Quaternion.identity);

<<<<<<< Updated upstream
            // Calculate the next spawn time
            nextSpawnTime = Time.time + delay;

            // Disable spawning until the next spawn time
            canSpawn = false;
        }
    }
}
=======
            // Start the delay timer
            //StartCoroutine(EnableSpawnAfterDelay());
        }
    }

    // Coroutine to enable spawning after a delay
    private IEnumerator EnableSpawnAfterDelay()
    {
        canSpawn = false; // Disable spawning
        yield return new WaitForSeconds(delay); // Wait for the delay duration
        canSpawn = true; // Enable spawning
    }
}
>>>>>>> Stashed changes
