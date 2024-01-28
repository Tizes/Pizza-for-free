using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class car : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent agent;
    //GameObject cam = GameObject.FindWithTag("MainCamera");
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //agent.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y, cam.transform.position.z);
        //transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y, cam.transform.position.z);
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }
    private void OnCollisionEnter2D(Collision2D finish)
    {
        // Check if the collider belongs to the object you want to destroy
        if (finish.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = agent.velocity;
        agent.SetDestination(target.position);
        float angle = Mathf.Atan2(velocity.y, velocity.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle+87, Vector3.forward);
    }
}
