using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float num;
    public float cooldown = 8;
    public bool isCooldown = false;
    public GameObject charecter;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        num += 1 / cooldown * Time.deltaTime;
        if (num >= 60)
        {
            num = 0;
            isCooldown = false;
        }
    }
}
