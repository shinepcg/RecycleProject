using UnityEngine;
using System.Collections;

public class Trash : MonoBehaviour {

	public bool hitToTrashCan = false;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (goToTrashCan_ != null)
			return;
		
		transform.position += new Vector3 (-0.03f, 0, 0);
	}

	Coroutine goToTrashCan_ = null;

	public void GoToTrashCan(GameObject trashCan) {
		if (goToTrashCan_ != null) {
			StopCoroutine (goToTrashCan_);
		}
		goToTrashCan_ = StartCoroutine (GoToTrashCanCo (trashCan));
	}

	IEnumerator GoToTrashCanCo(GameObject trashCan) {
		while (!hitToTrashCan) {
			transform.position = 
				Vector3.Lerp (transform.position, trashCan.transform.position, 0.1f);
			yield return null;
		}
	}
}
