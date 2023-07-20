using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile1 : MonoBehaviour
{
    public Transform projectile;
    public float speed;
    public int damage;
    [SerializeField] public GameObject PlasmaEffect;


    // Start is called before the first frame update
    void Start()
    {
        Vector3 objectScale = transform.localScale;
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(PlasmaEffect, projectile.transform.position, Quaternion.identity);
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        
        
    }
    private void FixedUpdate()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(gameObject);
        }
        if (collision.tag == "Bounds")
        {
            Destroy(gameObject);
        }
    }
}
