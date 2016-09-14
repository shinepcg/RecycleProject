using UnityEngine;
using System.Collections;

public class TrashCan : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) {

	}

	void OnTriggerStay (Collider other) {
		print ("[onTriggerStay" + other.name);
		Trash trash = other.GetComponent<Trash> ();
		if (trash) {
			if (!trash.OnHolding) {
				TrashSpawn.instance.RemoveTrash(other.gameObject);
				Destroy(other.gameObject);
				ScoreManager.instance.RemoveTrash ();
			}
		}
	}
}
