using UnityEngine;
using System.Collections;

public class PlayerCtrl : MonoBehaviour {

	private float h = 0.0f;
	private float v = 0.0f;

	private Transform trans;

	public float rotSpeed = 100.0f;

	// Use this for initialization
	void Start () {
		trans = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		h = Input.GetAxis ("Horizontal");
		v = Input.GetAxis ("Vertical");

		Debug.Log("H = " + h.ToString());
		Debug.Log("V = " + v.ToString());

		trans.Rotate (Vector3.up * Time.deltaTime * rotSpeed * Input.GetAxis("Mouse X"));
	}
}
