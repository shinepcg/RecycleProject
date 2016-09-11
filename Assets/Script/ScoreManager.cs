using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	public static ScoreManager instance;
	int score = 0;
    int missScore = 5;

	public int Score {
		get { return score; }
	}
    public int MissScore
    {
        get { return missScore; }
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
    public void FailClassify() {
        missScore -= 1;
    }


}
