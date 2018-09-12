using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedIncreaser : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        GameObject.Find("SardineSkinWithDemoScript").GetComponent<SpeedManager>().speed += 0.03f;
    }
}
