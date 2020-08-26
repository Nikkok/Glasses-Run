﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tnt : MonoBehaviour
{
    public int damage = 1;
    public float speed;

    public GameObject effect;

    private void Update()
    {
        // Tnt laatikko liikkuu pelaajaa kohti
        transform.Translate(Vector2.left * speed * Time.deltaTime); 
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            // Pelaaja ottaa vahinkoa osuessaan viholliseen
            other.GetComponent<PlayerController>().health -= damage;
            // Ilmoittaa pelajaan elämät konsolissa
            Debug.Log(other.GetComponent<PlayerController>().health);
            // Pelihahmon osuessa objektiin se tuhoutuu
            Destroy(gameObject); 
        }


    }



}
