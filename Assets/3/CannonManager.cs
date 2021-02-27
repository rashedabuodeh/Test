using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonManager : MonoBehaviour
{
    public Transform[] CannonSpawnPoints;
    public GameObject CannonballPrefab;
    public List<GameObject> CannonballPool;



    private void Start()
    {
        for (int i = 0; i < CannonSpawnPoints.Length; i++)
        {
            GameObject Cannonball = Instantiate(CannonballPrefab, CannonSpawnPoints[i]);

            Cannonball.SetActive(false);
            CannonballPool.Add(Cannonball);

        }
    }

    private void Update()
    {
        InvokeRepeating("RequestCannonball", 0.25f, 1f);

        //RequestCannonball();

    }

    public void  RequestCannonball()
    {
        for (int i = 0; i < CannonSpawnPoints.Length; i++)
        {
            if (CannonballPool[i].activeSelf == false)
            {
                CannonballPool[i].SetActive(true);
            }
        }


    }

}
