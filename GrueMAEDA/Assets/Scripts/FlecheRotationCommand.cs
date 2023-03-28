using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlecheRotationCommand : MonoBehaviour
{
    public GameObject Mat;
	public string axe;

    void Update()
    {
        float input = Input.GetAxis(axe);
        EtatFlecheRotation rotationEtat = MoveStateForInput(input);
        FlecheRotationController controller = Mat.GetComponent<FlecheRotationController>();
        controller.rotationEtat = rotationEtat;
    }

    EtatFlecheRotation MoveStateForInput(float input)
    {
        if (input > 0)
        {
            return EtatFlecheRotation.Positif;
        }
        else if (input < 0)
        {
            return EtatFlecheRotation.Negatif;
        }
        else
        {
            return EtatFlecheRotation.Fixe;
        }
    }
}
