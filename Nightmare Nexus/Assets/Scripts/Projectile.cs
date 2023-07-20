using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Transform projectile;
    public float speed;
    public int damage;
    [SerializeField] public GameObject FireEffect;
   

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        Instantiate(FireEffect, projectile.transform.position, Quaternion.identity);
        
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(gameObject);
        }
        else if (collision.tag == "Bounds")
        {
            Destroy(gameObject);
        }
    }
}
