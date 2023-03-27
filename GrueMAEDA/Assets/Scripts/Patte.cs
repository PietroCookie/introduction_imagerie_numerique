using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patte : MonoBehaviour
{
	// public GameObject motorRotation;

	public int speed;
	public string axe;

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis(axe);

		transform.Rotate(new Vector3(0, 0, input) * speed);
    }
}
