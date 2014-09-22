using UnityEngine;
using System.Collections;

public class WallCtrl : MonoBehaviour {

	public GameObject sparkEffect;

	void OnCollisionEnter (Collision collision){
		if(collision.collider.tag == "BULLET"){
			Vector3 firePos = collision.gameObject.GetComponent<BulletCtrl>().firePos;
			Vector3 relativePos = firePos - collision.transform.position;

			Object obj = Instantiate(sparkEffect, collision.transform.position, Quaternion.identity);
			Destroy(obj, 1.0f);
//			Instantiate(sparkEffect, collision.transform.position, Quaternion.identity);
			Destroy(collision.gameObject);
		}
	}
}
