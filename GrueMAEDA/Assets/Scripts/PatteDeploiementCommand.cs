using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatteDeploiementCommand : MonoBehaviour
{
    public GameObject Patte;

	public string axePatte;


    void Update()
    {
        float input = Input.GetAxis(axePatte);
        EtatPatteDeploiement rotationEtat = MoveStateForInput(input);

        PatteDeploiementController controller = Patte.GetComponent<PatteDeploiementController>();
        controller.rotationEtat = rotationEtat;
    }

    EtatPatteDeploiement MoveStateForInput(float input)
    {
        if (input > 0)
        {
            return EtatPatteDeploiement.Positif;
        }
        else if (input < 0)
        {
            return EtatPatteDeploiement.Negatif;
        }
        else
        {
            return EtatPatteDeploiement.Fixe;
        }
    }
}
