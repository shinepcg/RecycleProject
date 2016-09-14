using UnityEngine;
using System.Collections;
using System.Collections.Generic;

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
		List<GameObject> trashes = new List<GameObject> ();
		trashes.Add (TrashSpawn.instance.originalTrashes [0]);
		trashes.Add (TrashSpawn.instance.originalTrashes [1]);
		trashes.Add (TrashSpawn.instance.originalTrashes [2]);
		trashes.Add (TrashSpawn.instance.originalTrashes [3]);
		TrashSpawn.instance.activeTrashes = trashes.ToArray ();
	}
}
