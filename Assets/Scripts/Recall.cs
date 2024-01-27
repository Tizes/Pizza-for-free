using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Recall : MonoBehaviour
{
    public float countdown = 10;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (countdown > 0)
        {
            countdown -= Time.deltaTime;
            
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
