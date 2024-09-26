using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.AI;

public class Bober : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject treeObj;
   


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

    }

    
    private void OnCollisionEnter2D(Collision2D other)
    {
        // Check if the collider belongs to the object you want to destroy
        if (other.gameObject.tag == "Tree")
        {
            Destroy(other.gameObject);
            agent.speed += 0.1f;  
        }
    }
    // Update is called once per frame
    void Update()
    {
        treeObj = GameObject.FindWithTag("Tree");
        if (treeObj)
        {
            Vector2 velocity = agent.velocity;
            agent.SetDestination(treeObj.transform.position);
            float angle = Mathf.Atan2(velocity.y, velocity.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}

