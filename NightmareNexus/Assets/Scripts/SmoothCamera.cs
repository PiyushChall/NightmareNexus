using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCamera : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(0f, 0f, -5f);
    public float camSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        Vector3 desiredPos = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPos, camSpeed * Time.deltaTime);
    }
}
