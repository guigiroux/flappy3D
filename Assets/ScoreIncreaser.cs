using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreIncreaser : MonoBehaviour {

    public int score;
    public Text scoreText;
    public AudioSource source;
	void Start () {
        score = 0;
        SetScoreText();

    }
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other)
    {
        if (GameObject.Find("SardineSkinWithDemoScript").GetComponent<GameManager>().inGame == true)
        {
            score += 1;
            SetScoreText();
            source.Play();
        }
    }

    void SetScoreText()
    {
        scoreText.text = score.ToString();
    }
}
