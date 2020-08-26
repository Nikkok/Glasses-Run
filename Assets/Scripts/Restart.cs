using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Peli alkaa alusta eli scene latautuu uudelleen
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
        }
    }





}
