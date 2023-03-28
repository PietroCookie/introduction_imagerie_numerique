using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatteCommand : MonoBehaviour
{
	public string axe;

	public GameObject patte;

    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis(axe);
		EtatPatteRotation rotationEtat = MoveStateForInput(input);


        PatteController controller = patte.GetComponent<PatteController>();
		controller.rotationEtat = rotationEtat;
    }

	EtatPatteRotation MoveStateForInput(float input) {
		 if (input > 0)
        {
            return EtatPatteRotation.Positif;
        }
        else if (input < 0)
        {
            return EtatPatteRotation.Negatif;
        }
        else
        {
            return EtatPatteRotation.Fixe;
        }
	}
}
