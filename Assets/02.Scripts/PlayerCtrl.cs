using UnityEngine;
using System.Collections;

public class PlayerCtrl : MonoBehaviour {

	private float h = 0.0f;
	private float v = 0.0f;

	private Transform tr;
	public float moveSpeed = 10.0f;

	// Use this for initialization
	void Start () {
		tr = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		h = Input.GetAxis ("Horizontal");
		v = Input.GetAxis ("Vertical");

		Debug.Log("H = " + h.ToString());
		Debug.Log("V = " + v.ToString());

		tr.Translate(Vector3.forward * moveSpeed * v * Time.deltaTime, Space.Self);
	}
}
