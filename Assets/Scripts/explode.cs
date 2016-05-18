using UnityEngine;
using System.Collections;

public class explode : MonoBehaviour {

	private GameObject ShellExplosionPrefab; 

	// Use this for initialization
	void Start () {

	}
	void OnTriggerEnter(Collider collision) {
		
			//Find Child and remove its Parent
			ShellExplosionPrefab = transform.Find ("ShellExplosion").gameObject;
			ShellExplosionPrefab.transform.parent = null;

			//Play explosion and audio and destroy object
			Destroy (gameObject);
			ShellExplosionPrefab.GetComponent<ParticleSystem>().Play();
			ShellExplosionPrefab.GetComponent<AudioSource> ().Play ();
			Destroy (ShellExplosionPrefab, 1.0f);
	}
	// Update is called once per frame
	void Update () {


	}
}
