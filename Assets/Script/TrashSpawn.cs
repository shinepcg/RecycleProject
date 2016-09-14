using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TrashSpawn : MonoBehaviour {
	
	public static TrashSpawn instance;
	public GameObject[] originalTrashes;
	public GameObject[] activeTrashes;
	public List<GameObject> trashList;

	// Use this for initialization
	IEnumerator Start () {
		while (true) {
			int randNum = Random.Range (0, activeTrashes.Length);

			GameObject newTrash = 
				(GameObject)Instantiate(activeTrashes [randNum], transform.position, Quaternion.identity);
			
			Trash trash = newTrash.GetComponent<Trash> ();
			trash.Speed = LevelManager.instance.TrashSpeed;

			trashList.Add (newTrash);


			yield return new WaitForSeconds (LevelManager.instance.SpawnIntervalSec);
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
}
