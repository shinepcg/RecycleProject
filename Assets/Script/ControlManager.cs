using UnityEngine;
using System.Collections;

public class ControlManager : MonoBehaviour {

	GameObject draggingObj;
	// Use this for initialization
	void Start () {
	
	}
    
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit = new RaycastHit ();
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			Physics.Raycast (ray.origin, ray.direction, out hit, Mathf.Infinity);

			if (hit.transform.tag == "trash") {
				hit.transform.GetComponent<Trash> ().Hold ();
				draggingObj = hit.transform.gameObject;
			}
		}
		else if (Input.GetMouseButton (0)) {
			if (draggingObj) {
				RaycastHit hit = new RaycastHit ();
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				Physics.Raycast (ray.origin, ray.direction, out hit, Mathf.Infinity);

				print ("[ControlManager]" + hit.transform.name + ", " + hit.transform.position);
				draggingObj.transform.position = new Vector3 (hit.point.x, draggingObj.transform.position.y, hit.point.z);
			}
		}
		else if (Input.GetMouseButtonUp (0)) {
			if (draggingObj) {
				Trash trash = draggingObj.GetComponent<Trash> ();
				if (trash) 
					trash.ReleaseHolding ();
			}
			draggingObj = null;
		}

	}
}
