using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannonball : MonoBehaviour
{
    private float initialVelocity = 3;
    private float angle = 5f;
    private float gravity = 1f;
    private float velocityZ;
    private float velocityY;
    private float startTime;

    private void Start()
    {
        startTime = Time.time;
    }

    private void FixedUpdate()
    {
        velocityZ = initialVelocity * Mathf.Cos(angle * Mathf.Deg2Rad) * 0.05f;
        velocityY = ((initialVelocity * Mathf.Sin(angle * Mathf.Deg2Rad)) - gravity * (Time.time - startTime)) * 0.05f;

        UpdateCannonballPosition(gameObject);
    }

    private void UpdateCannonballPosition(GameObject cannonball)
    {
        Transform t = cannonball.GetComponent<Transform>();

        if(t.position.y > -0.5f)
        {
            t.localPosition = new Vector3(t.localPosition.x, t.localPosition.y + velocityY, t.localPosition.z + velocityZ);
        }
    }
}
