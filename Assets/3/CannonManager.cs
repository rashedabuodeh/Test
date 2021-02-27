using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonManager : MonoBehaviour
{
    public Transform[] CannonSpawnPoints;
    public GameObject CannonballPrefab;

    private void Start()
    {
        InvokeRepeating("Shoot", 0.25f, 1f);
    }

    private void Shoot()
    {
        for (int i = 0; i < CannonSpawnPoints.Length; i++)
        {
            Instantiate(CannonballPrefab, CannonSpawnPoints[i]);
        }
    }
}
