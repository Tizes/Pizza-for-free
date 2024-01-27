using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{

    public GameObject cubePrefab; // Reference to the cube prefab

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Check for mouse button click
        if (Input.GetMouseButtonDown(0))
        {
            // Get the mouse position in screen space
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = -Camera.main.transform.position.z;


            // Convert the mouse position from screen space to world space
            //Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            // Ensure z position is 0 in 2D space
            //Vector3 point = new Vector3(mousePos.x, mousePos, Camera.main.nearClipPlane);

            var a = Camera.main.ScreenToWorldPoint(mousePosition);
            //worldMousePosition.z = 0f;


            // Spawn the cube at the mouse position
            a.z = 0f;
            Instantiate(cubePrefab, a, Quaternion.identity);
            Debug.Log(mousePosition);
        }
    }
}
