using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	public static ScoreManager instance;
	int score = 0;
	public int Score {
		get { return score; }
	}

	// Use this for initialization
	void Start () {
	}

	void Awake() {
		instance = this;
	}

	public void RemoveTrash() {
		score += 10;
	}
}
