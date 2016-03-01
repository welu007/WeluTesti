using UnityEngine;
using System.Collections;

public class BounceSound : MonoBehaviour {
	public AudioSource audio;

	void OnCollisionEnter(Collision collision) {
		foreach (ContactPoint contact in collision.contacts) {
			Debug.DrawRay(contact.point, contact.normal, Color.white);
		}

		//if (collision.relativeVelocity.magnitude > 2)
			audio.Play(); 
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
