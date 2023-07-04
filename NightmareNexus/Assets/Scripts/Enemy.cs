using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{ 
    public GameObject player;
    public float enemySpeed;
    public float distanceBetween;
    private float distance;

    Rigidbody2D rb;

    public Player playerScript;

    // Start is called before the first frame update
    private void Awake()
    {
       rb = GetComponent<Rigidbody2D>();

    }

    // // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        distance = Vector2.Distance(transform.position, player.transform.position);

        if(distance < distanceBetween)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, enemySpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);

        }
    }
}
