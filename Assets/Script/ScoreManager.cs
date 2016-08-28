using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	public static ScoreManager instance;
	int score = 0;

	// Use this for initialization
	void Start () {
	}

	void Awake() {
		instance = this;
	}

	public int GetScore() {
		return score;
	}

	public void RemoveTrash() {
		score += 10;
	}
}
