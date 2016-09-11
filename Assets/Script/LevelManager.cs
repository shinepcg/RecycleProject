using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public static LevelManager instance;
	float trashSpeed = 0;
	public float TrashSpeed {
		get { return trashSpeed; }
	}
	float spawnIntervalSec = 0;
	public float SpawnIntervalSec {
		get { return spawnIntervalSec; }
	}

	// Use this for initialization
	void Start () {
		SetLevel1 ();
	}

	void Awake() {
		instance = this;
	}

	void SetLevel1() {
		trashSpeed = 0.05f;
		spawnIntervalSec = 1.5f;
		TrashSpawn.instance.ActiveTrashes = TrashSpawn.instance.originalTrasheObjs;
	}
}
