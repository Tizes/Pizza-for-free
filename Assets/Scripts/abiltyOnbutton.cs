using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class abiltyOnbutton : MonoBehaviour
{

    [SerializeField] GameObject go;

    // Start is called before the first frame update
    public void spawn()
    {
        GameObject obsticale = Instantiate(go);
        obsticale.transform.position = new Vector3((float)-7.05,(float)-28.5,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
