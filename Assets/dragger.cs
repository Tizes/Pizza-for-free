using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragger : MonoBehaviour
{
    public float speed = 5f; // Adjust the speed of movement as needed
    public float minDistance = 0.1f; // Minimum distance from cursor to move

    public GameObject[] objectsToSpawn; // Array to hold objects to spawn

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Check for left mouse button click
        {
            // Raycast from the mouse position to find the position to spawn the object
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo)) // If raycast hits something
            {
                // Get the position to spawn the object
                Vector3 spawnPosition = hitInfo.point;

                // Spawn a random object from the objectsToSpawn array
                int randomIndex = Random.Range(0, objectsToSpawn.Length);
                GameObject objectToSpawn = objectsToSpawn[randomIndex];
                Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
            }
        }
    }
}