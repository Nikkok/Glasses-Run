using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaclePatterns;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;

    private void Update()
    {
        // Jos edellisestä vihollisen spawnista kulunut nolla tai alle 
        if (timeBtwSpawn <= 0) 
        {
            int rand = Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
            // Edellisen vihollísen  spawnauksesta kestää tietty aika ennen seuraavaa
            timeBtwSpawn = startTimeBtwSpawn;
            //Aika pysyy minimi ajan yläpuolella
            if (startTimeBtwSpawn > minTime){
                // Aika seuraavan vihollisen spawnaukseen vähenee
                startTimeBtwSpawn -= decreaseTime; 
            } 
            
        }
        else
        {
            // Jos aika ei ole nolla, vähennetään kunnes se on 
            timeBtwSpawn -= Time.deltaTime; 
        }
    }
       
}
