
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreePlacer : MonoBehaviour
{
    public GameObject spawner;
    public int spawnnumber;
    // Start is called before the first frame update
    public void Tree()
    {
      
        spawner.SetActive(true);
        spawner.GetComponent<SpawnObjects>().number = spawnnumber;
        
    }
}
