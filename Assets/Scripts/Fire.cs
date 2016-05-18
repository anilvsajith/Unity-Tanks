	using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	public int m_PlayerNumber;
	public Rigidbody BulletPrefab;
	public float speed = 10f;
	private string m_Playerfire;
	private float starttime;
	private float timepressed;
	// Use this for initialization
	void Start () {
		m_Playerfire = "Fire" + m_PlayerNumber;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown(m_Playerfire))
		{		
			starttime = Time.time;
		}

		if(Input.GetButtonUp(m_Playerfire))
		{
			timepressed = Time.time - starttime;
			timepressed = timepressed * 10;
			timepressed = Mathf.Max (timepressed, 2.0f);
			timepressed = Mathf.Min (timepressed, 4);
			//Insatiate a new bullet on this object (which will be our camera)
			Rigidbody mBullet = Instantiate (BulletPrefab, transform.position, transform.rotation) as Rigidbody;

			//Add force to the bullet to shoot it
			mBullet.AddForce (transform.forward * 500 * timepressed);


			GameObject.Destroy (mBullet.gameObject, 3.0f);
		}

	}
}
