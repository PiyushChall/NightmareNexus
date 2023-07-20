using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAI : MonoBehaviour
{
    private float speed;
    Transform player;
    private int health;
    private int maxHealth = 3;
    [SerializeField] FloatingHealthBar healthBar;
    private int gameoverScene = 3;
    [SerializeField] public GameObject DeathEffect;
    

    // Start is called before the first frame update
    void Start()
    {

        
        speed = Random.Range(4f, 7.5f);
        health = maxHealth;
        player = FindObjectOfType<PlayerMovements>().transform;
        healthBar = GetComponentInChildren<FloatingHealthBar>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "FireBall")
        {
            
            takeDamage(collision.GetComponent<Projectile>().damage);
        }
        else if (collision.tag == "PlasmaBall")
        {
            
            takeDamage(collision.GetComponent<Projectile1>().damage);
        }
        else if (collision.tag == "Player")
        {

            SceneManager.LoadScene(gameoverScene);
        }
    }
    void takeDamage(int damageAmount)
    {
        health -= damageAmount;
        healthBar.UpdateHealthBar(health, maxHealth);
        if (health <= 0)
        {
           

            die();
            Instantiate(DeathEffect, transform.position, Quaternion.identity);
        }
    }
    void die()
    {
        Destroy(gameObject);
    }

}
