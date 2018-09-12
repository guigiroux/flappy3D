using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOverManager : MonoBehaviour {

    public GameObject endMenu;
    public GameObject scoreMenu;
    public Text scoreText;
    public Text bestScoreText;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("SardineSkinWithDemoScript").GetComponent<GameManager>().inGame == false)
        {
            ShowMenuEnd();
        }

    }

    void ShowMenuEnd()
    {
        int actualScore = GameObject.Find("TriggerSpeeder").GetComponent<ScoreIncreaser>().score;
        if (actualScore > PlayerPrefs.GetInt("score"))
        {
            PlayerPrefs.SetInt("score", actualScore);
        }
        endMenu.SetActive(true);
        scoreMenu.SetActive(false);
        scoreText.text = actualScore.ToString();
        bestScoreText.text = PlayerPrefs.GetInt("score").ToString();
    }
}
