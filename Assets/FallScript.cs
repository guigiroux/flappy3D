using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallScript : MonoBehaviour {
    private Rigidbody rbody;
    public float speed;
    public AudioSource source;
    // Use this for initialization
    void Start () {
        rbody = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
        rbody.AddForce(0, -speed, 0, ForceMode.VelocityChange);
        if (Input.GetKeyDown("space") == true && GameObject.Find("SardineSkinWithDemoScript").GetComponent<GameManager>().inGame == true)
        {
            source.Play();
            rbody.velocity = new Vector3(0, 0, 0);
            rbody.AddForce(0, 77, 0, ForceMode.VelocityChange);
        }
	}
}
