using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Cooldown1 : MonoBehaviour
{
    public Image imageCooldown;
    public float cooldown = 8;
    public bool isCooldown= false;
    public GameObject charecter;

    
        
  
    async void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && isCooldown == false)
        {
            isCooldown = true;
            

        }
        
            if (isCooldown)
            {
                imageCooldown.fillAmount += 1 / cooldown * Time.deltaTime;
                if (imageCooldown.fillAmount >= 1)
                {
                    imageCooldown.fillAmount = 0;
                    isCooldown = false;
                }
            }
        }
    
}
