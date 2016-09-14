using UnityEngine;
using System.Collections;

public class Trash : MonoBehaviour {
	public Vector3 moveVec = new Vector3();
	float speed = 0.05f;
	public float Speed {
		get { return speed; }
		set { speed = value;}
	}
	public bool onHolding = false;
	public bool OnHolding {
		get { return onHolding; }
	}

	// Use this for initialization
	void Start () {
		moveVec = new Vector3 (-speed, 0, 0);
	}

	// Update is called once per frame
	void Update () {
		if (moveVec != Vector3.zero) 
			transform.position += moveVec;
	}

	public void Hold() {
		// stop moving
		moveVec = Vector3.zero;
		onHolding = true;
	}

	public void ReleaseHolding() {
		onHolding = false;
	}
}
