using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlecheCommande : MonoBehaviour
{
    public GameObject Fleche;


    void Update()
    {
        float input = Input.GetAxis("Fleche");
        EtatFleche rotationEtat = MoveStateForInput(input);
        FlecheControleur controller = Fleche.GetComponent<FlecheControleur>();
        controller.rotationEtat = rotationEtat;

        
    }

    EtatFleche MoveStateForInput(float input)
    {
        if (input > 0)
        {
            return EtatFleche.Positif;
        }
        else if (input < 0)
        {
            return EtatFleche.Negatif;
        }
        else
        {
            return EtatFleche.Fixe;
        }
    }
}
