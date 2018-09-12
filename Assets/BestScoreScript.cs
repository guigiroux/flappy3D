using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScoreScript : MonoBehaviour {

    public Text bestScore;
	// Use this for initialization
	void Start () {
        bestScore.text = PlayerPrefs.GetInt("score").ToString();
	}
}
