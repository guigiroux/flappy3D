using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    public GameObject mid;
    public GameObject midLow;
    public GameObject midHigh;
    public GameObject high;
    public GameObject low;
    public Transform spawnPosition;

    void Start()
    {
        InstantiateRandomObject();
    }
	void OnTriggerEnter(Collider other)
    {
            InstantiateRandomObject();
    }

    void InstantiateRandomObject()
    {
        System.Random rnd = new System.Random();
        int number = rnd.Next(1, 6);
        switch(number)
        {
            case 1:
                Instantiate(mid, spawnPosition.position, spawnPosition.rotation);
                break;
            case 2:
                Instantiate(midLow, spawnPosition.position, spawnPosition.rotation);
                break;
            case 3:
                Instantiate(midHigh, spawnPosition.position, spawnPosition.rotation);
                break;
            case 4:
                Instantiate(high, spawnPosition.position, spawnPosition.rotation);
                break;
            case 5:
                Instantiate(low, spawnPosition.position, spawnPosition.rotation);
                break;
        }
    }
}
