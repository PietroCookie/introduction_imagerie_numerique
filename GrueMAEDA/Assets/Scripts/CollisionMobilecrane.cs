using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMobilecrane : MonoBehaviour
{
	public string tagIgnoreCollision;

	private void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag == tagIgnoreCollision) {
			Physics.IgnoreCollision(collision.gameObject.GetComponent<Collider>(), GetComponent<Collider>());
		}
	}
}
