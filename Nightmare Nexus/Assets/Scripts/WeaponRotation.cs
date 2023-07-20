using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRotation : MonoBehaviour
{
    public Transform weapon;
    private float offset = 90f;

    public Transform wandTip;
    public GameObject projectile;
    public GameObject projectile2;
    private float timeBetweenMagic1 = 0.2f;
    private float timeBetweenMagic2 = 1.5f;
    private float nextMagicTime;
    public AudioClip fireball;
    public AudioClip plasmaball;
    public AudioSource source;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Wand Rotation.
        Vector3 displacement = weapon.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(displacement.y, displacement.x) * Mathf.Rad2Deg;
        weapon.rotation = Quaternion.Euler(0f, 0f, angle + offset);

        //Magic.
        if (Input.GetMouseButtonDown(0))
        {
            if (Time.time > nextMagicTime)
            {
                source.clip = fireball;
                source.Play();
                nextMagicTime = Time.time + timeBetweenMagic1;
                Instantiate(projectile, wandTip.position, wandTip.rotation);
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (Time.time > nextMagicTime)
            {
                source.clip = plasmaball;
                source.Play();
                nextMagicTime = Time.time + timeBetweenMagic2;
                Instantiate(projectile2, wandTip.position, wandTip.rotation);
            }
        }
    }
}
