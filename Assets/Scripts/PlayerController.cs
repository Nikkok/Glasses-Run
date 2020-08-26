using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;

    public float speed;
    public float maxHeight;
    public float minHeight;

    public int health = 3;

    public GameObject effect;
    public Text healthDisplay;

    public GameObject gameover;
    private void Update()
    {
        healthDisplay.text = health.ToString();

        if (health <= 0)
        {
            gameover.SetActive(true);
            Destroy(gameObject);
        }
        // Pelihahmo liikkuu haluttuun paikkaan tietyllä nopeudella
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        // Tarkistaa onko pelaaja painanut ala nuolinäppäintä ja estetään pelihahmon liikkuminen ruudu ulkopuolelle
        if (Input.GetKeyDown(KeyCode.UpArrow)&& transform.position.y < maxHeight) 
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            // Kun pelaaja painaa ylä nuolinäppäintä pelihahmo liikkuu ylöspäin
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);

        } // Tarkistaa onko pelaaja painanut ala nuolinäppäintä ja estetään pelihahmon liikkuminen ruudu ulkopuolelle
        else if (Input.GetKeyDown(KeyCode.DownArrow)&& transform.position.y > minHeight) 
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            // Kun pelaaja painaa ala nuolinäppäintä pelihahmo liikkuu alaspäin
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement); 
            
        }
    }
}
