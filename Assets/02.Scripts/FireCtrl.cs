using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class FireCtrl : MonoBehaviour {

	public GameObject bullet;
	public Transform firePos;
	public AudioClip fireSfx;


	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Fire();
		}
	}

	void Fire(){
		StartCoroutine(this.CreateBullet());
		StartCoroutine(this.PlaySfx(fireSfx));
	}

	IEnumerator CreateBullet(){
		Instantiate (bullet, firePos.position, firePos.rotation);
		yield return null;
	}

	IEnumerator PlaySfx(AudioClip _clip)
	{
		audio.PlayOneShot(_clip, 0.9f);
		yield return null;
	}
}
