using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grappin : MonoBehaviour
{

	public string axe;

    void OnCollisionEnter(Collision Collision) {
        if (Collision.gameObject.name == "Crochet" && Collision.gameObject.GetComponent<ArticulationBody>() != null) {
            FixedJoint joint = this.gameObject.AddComponent<FixedJoint>();
            joint.connectedArticulationBody = Collision.articulationBody;
        }
    }

    // Update is called once per frame
    void Update() {
        float input = Input.GetAxis(axe);

		if(input > 0)
        	Destroy(this.gameObject.GetComponent<FixedJoint>());
    }
}
