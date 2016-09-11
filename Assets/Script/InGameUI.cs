using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour {

	Text txtScore;
    Text missScore;

	// Use this for initialization
	void Start () {
	
	}

	void Update() {
		txtScore.text = ScoreManager.instance.Score.ToString();
        //missScore.text = ScoreManager.
	}

	void Awake() {
		txtScore = transform.FindChild ("LabelScore/TxtScore").GetComponent<Text>();
        missScore = transform.FindChild("LabelMissScore/MissScore").GetComponent<Text>();
        txtScore.text = "0";
        missScore.text = "5";
    }

	public void MessageBack() {
		print ("MessageBack");
	}
}
