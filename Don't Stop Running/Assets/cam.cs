using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class cam : MonoBehaviour {

	float ydir = 0f;
	public GameObject player;
    public Text ScoreText; 
    public float ScoreAmount; 
    public float ScoreIncreased; 
    
    void Start()
    {
        ScoreAmount = 0f; 
        ScoreIncreased = 1f; 
    }

	// Use this for initialization

	// Update is called once per frame
	void Update () {
        ScoreText.text = "Score: " + (int)ScoreAmount; 
		//check that player exists and then proceed. otherwise we get an error when player dies
		if (player) {
            ScoreAmount += ScoreIncreased * Time.deltaTime;
			//if player has passed the x position of -1 then start moving camera forward with a randomish Y position
			if (player.transform.position.x > -1) {

				
				float randy = 0f;
				randy = Random.Range (0f, 100f);
				if (randy < 20) {
					ydir = ydir + .005f;
				} else if (randy > 20 && randy < 40) {
					ydir = ydir - .005f;
				} else if (randy > 80) {
					ydir = 0f;
				}
				transform.position = new Vector3 (transform.position.x + 0.03f, transform.position.y + ydir, -10);
			}
		}
	}
}