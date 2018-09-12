using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndDestroy : MonoBehaviour {

    private float speed;
	void Start () {
        speed = GameObject.Find("SardineSkinWithDemoScript").GetComponent<SpeedManager>().speed;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0, 0, -speed);
        if (transform.position.z <= -200)
        {
            speed = GameObject.Find("SardineSkinWithDemoScript").GetComponent<SpeedManager>().speed;
            Destroy(this.gameObject);
        }
	}
}
