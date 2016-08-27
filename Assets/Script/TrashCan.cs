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
		print ("[onTriggerEnger" + other.name);
		Trash trash = other.GetComponent<Trash> ();
		trash.hitToTrashCan = true;
		Destroy(other.gameObject);
	}
}
