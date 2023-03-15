using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGrue : MonoBehaviour
{
	public float torque = 250f;
	public float forceChariot = 500f;
	public float forceMoufle = 500f;
	public ArticulationBody pivot;
	public ArticulationBody chariot;
	public ArticulationBody moufle;

    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
        //commandes pour la fleche
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			pivot.AddTorque(transform.up * -torque);
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			pivot.AddTorque(transform.up * torque);
		}

		//commandes pour le chariot
		if (Input.GetKey(KeyCode.UpArrow))
		{
			chariot.AddRelativeForce(transform.right * forceChariot);
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			chariot.AddRelativeForce(transform.right * -forceChariot);
		}

		//commande pour la moufle
		if (Input.GetKey(KeyCode.LeftShift))
		{
			moufle.AddRelativeForce(transform.up * forceMoufle);
		}
		if (Input.GetKey(KeyCode.LeftControl))
		{
			moufle.AddRelativeForce(transform.up * -forceMoufle);
		}
    }
}
