using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawningClouds : MonoBehaviour
{
    public GameObject CloudPrefab, Teleport; //reference for your object
    GameObject TeleportPrefab;
    public int myCount = 5, j = 0; //count created objects
    public Sprite[] cloudsprite;

  private void Awake()
    {
        TeleportPrefab = Instantiate(Teleport, transform.parent);
        TeleportPrefab.SetActive(false);

    }

    void Start()
    {

        while (j < myCount)
        {
            Vector3 randPos = (new Vector3(Random.Range(-800, 800), Random.Range(-800f, 800f),0));
           // TeleportPrefab = Instantiate(Teleport, transform.parent);

            TeleportPrefab.SetActive(true);
            TeleportPrefab.transform.localPosition = randPos;
          
            StartCoroutine(wait());

            if (Teleportobj.Allclear )
            {
                // all clear for clouds to appear!
                var Cloud = Instantiate(CloudPrefab,transform.parent);
                Cloud.transform.localPosition = randPos;
                Cloud.GetComponent<Image>().sprite = cloudsprite[Random.Range(0,7)];
                j++;
            }
           // Destroy(TeleportPrefab);
            TeleportPrefab.SetActive(false);

        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(10f);

    }


}




