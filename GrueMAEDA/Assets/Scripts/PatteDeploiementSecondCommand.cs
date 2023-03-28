using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatteDeploiementSecondCommand : MonoBehaviour
{
	public GameObject Patte;

	public string axePatte;

	void Update()
    {
        float input = Input.GetAxis(axePatte);
		EtatPatteDeploiementSecond rotationEtat = MoveStateForInput(input);

        PatteDeploiementSecondController controller = Patte.GetComponent<PatteDeploiementSecondController>();
        controller.rotationEtat = rotationEtat;
    }
   
   EtatPatteDeploiementSecond MoveStateForInput(float input)
    {
        if (input > 0)
        {
            return EtatPatteDeploiementSecond.Positif;
        }
        else if (input < 0)
        {
            return EtatPatteDeploiementSecond.Negatif;
        }
        else
        {
            return EtatPatteDeploiementSecond.Fixe;
        }
    }
}
