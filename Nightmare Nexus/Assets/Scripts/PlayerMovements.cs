using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovements : MonoBehaviour
{
    public float speed;
    public int went2Far;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float posX = Input.GetAxisRaw("Horizontal");
        float posY = Input.GetAxisRaw("Vertical");

        Vector3 playerInput = new Vector3(posX, posY,0);
        transform.position += playerInput.normalized * speed * Time.deltaTime;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bounds")
        {
            SceneManager.LoadScene(went2Far);
        }
    }
}
