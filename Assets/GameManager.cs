using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public bool inGame;
    public AudioClip clip;
    public AudioSource source;
	void Start () {
        inGame = true;
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
        inGame = false;
        source.clip = clip;
        source.Play();
	}
}
