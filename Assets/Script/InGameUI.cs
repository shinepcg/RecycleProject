using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour {

	Text txtScore;

	// Use this for initialization
	void Start () {
	
	}

	void Update() {
		txtScore.text = ScoreManager.instance.GetScore ().ToString();
	}

	void Awake() {
		txtScore = transform.FindChild ("TxtScore").GetComponent<Text>();
		txtScore.text = "0";
	}

	public void MessageBack() {
		print ("MessageBack");
	}
}
