using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TrashSpawn : MonoBehaviour {
	
	public static TrashSpawn instance;
	public GameObject[] trashes;
	public List<GameObject> trashList;
	float spawnIntervalSec = 1.5f;
	public float SpawnIntervalSec{
		get { return spawnIntervalSec; }
	}

	// Use this for initialization
	IEnumerator Start () {
		while (true) {
			int randNum = Random.Range (0, 10);

			GameObject newTrash = 
				(GameObject)Instantiate(trashes[randNum], transform.position, Quaternion.identity);

			trashList.Add (newTrash);

			yield return new WaitForSeconds (spawnIntervalSec);
		}
	}

	void Awake() {
		instance = this;
	}

	public GameObject GetOldestTrash() {
		if (trashList.Count > 0) {
			return trashList [0];
		}
		return null;
	}

	public void RemoveTrash(GameObject trash) {
		trashList.Remove (trash);
	}

	public float IncreaseSpawnInterval() {
		spawnIntervalSec += 0.1f;
		return spawnIntervalSec;
	}
}
