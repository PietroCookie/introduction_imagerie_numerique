using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
	float speed = 1;
	float speedRotation = 100;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float inputForward = Input.GetAxis("Forward");
		float inputRotation = Input.GetAxis("RotationQD");
		
		transform.Translate(new Vector3(0, 0, inputForward) * speed * Time.deltaTime);
		transform.Rotate(new Vector3(0, inputRotation, 0) * speedRotation * Time.deltaTime);
	}
}
