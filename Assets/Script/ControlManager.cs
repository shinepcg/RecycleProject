using UnityEngine;
using System.Collections;

public class ControlManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void MoveTrashToCan(GameObject trash, GameObject can) {
		if (trash) {
			Trash trashComp = trash.GetComponent<Trash> ();
			trashComp.GoToTrashCan (can);
			TrashSpawn.instance.RemoveTrash (trash);
		}
	}
    
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit = new RaycastHit ();
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			Physics.Raycast (ray.origin, ray.direction, out hit, Mathf.Infinity);

			if (hit.transform.tag == "trashcan") {
				print ("[ControlManager]" + hit.transform.name);

				MoveTrashToCan (TrashSpawn.instance.GetOldestTrash (),
					hit.transform.gameObject);
			}
		}	
	}
}
