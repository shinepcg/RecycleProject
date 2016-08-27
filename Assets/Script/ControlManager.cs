using UnityEngine;
using System.Collections;

public class ControlManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit = new RaycastHit ();
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			Physics.Raycast (ray.origin, ray.direction, out hit, Mathf.Infinity);

			if (hit.transform.tag == "trashcan") {
				print ("[ControlManager]" + hit.transform.name);

				GameObject obj = TrashSpawn.instance.GetOldestTrash ();
				if (obj) {
					Trash trash = obj.GetComponent<Trash> ();
					trash.GoToTrashCan (hit.transform.gameObject);
				}
			}
		}	
	}
}
