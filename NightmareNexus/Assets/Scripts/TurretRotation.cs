using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretRotation : MonoBehaviour
{
    private Camera mainCam;
    public GameObject bullet;
    public Transform bulletTurret;
    private Vector3 mousePos;
    private float shoottimer;
    public bool canFire;
    public float timeBetweenFire;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePos - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);

        if (!canFire)
        {
            shoottimer += Time.deltaTime;
            if (shoottimer > timeBetweenFire)
            {
                canFire = true;
                shoottimer = 0;
            }
        }

        if (Input.GetMouseButtonDown(0) && canFire)
        {
            canFire = false;
            Instantiate(bullet, bulletTurret.transform.position, Quaternion.identity);
        }
        
    }
}
