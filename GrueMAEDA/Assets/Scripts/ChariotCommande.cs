using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChariotCommande : MonoBehaviour
{
    public GameObject Chariot;
    public string axe;

    void Update()
    {
        float input = Input.GetAxis(axe);
        EtatChariot moveState = EtatTranslationPrInput(input);
        ChariotControleur controller = Chariot.GetComponent<ChariotControleur>();
        controller.translationEtat = moveState;
    }

    EtatChariot EtatTranslationPrInput(float input)
    {
        if (input > 0)
        {
            return EtatChariot.Positif;
        }
        else if (input < 0)
        {
            return EtatChariot.Negatif;
        }
        else
        {
            return EtatChariot.Fixe;
        }
    }
}
