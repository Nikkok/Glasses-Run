using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBG : MonoBehaviour
{
    public float speed;

    public float endX;
    public float startX;

    // Update is called once per frame
    private void Update()
    { // Tausta liikkuu vasemmalle
        transform.Translate(Vector2.left * speed * Time.deltaTime); 

        if (transform.position.x <= endX)
        { // Kun taustan x-akselin sijainti on pienempi tai yhtä suuri kuin endX, se muuttaa sijaintinsa startX kohtaan
            Vector2 pos = new Vector2(startX, transform.position.y); 
            transform.position = pos;
        }



    }
}
