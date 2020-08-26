using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthDisplay : MonoBehaviour
{
    private int health = 3;
    public Text healthText;

    void Update()
    {
        // Näyttää pelin aikana montako elämää pelihahmolla on
        healthText.text = "HEALTH : " + health;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            health--;
        }





        
    }
}
