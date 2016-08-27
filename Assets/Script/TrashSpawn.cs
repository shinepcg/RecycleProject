using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TrashSpawn : MonoBehaviour {
	
	public static TrashSpawn instance;
	public GameObject[] trashes;
	public List<GameObject> trashList;

	// Use this for initialization
	IEnumerator Start () {
		while (true) {
			int randNum = Random.Range (0, 10);

			GameObject newTrash = 
				(GameObject)Instantiate(trashes[randNum], transform.position, Quaternion.identity);

			trashList.Add (newTrash);

			yield return new WaitForSeconds (2);
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

	public bool RemoveOldestTrash() {
		GameObject obj = GetOldestTrash ();
		if (obj == null)
			return false;
		
		trashList.Remove (obj);
		Destroy (obj);

		return true;
	}
}
