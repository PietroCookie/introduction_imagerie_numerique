using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrochetCommande : MonoBehaviour
{
	public GameObject Crochet;
	public string axe;

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis(axe);
		EtatCrochet moveState = EtatTranslationPrInput(input);
        CrochetController controller = Crochet.GetComponent<CrochetController>();
        controller.translationEtat = moveState;
    }

	EtatCrochet EtatTranslationPrInput(float input)
    {
        if (input > 0)
        {
            return EtatCrochet.Positif;
        }
        else if (input < 0)
        {
            return EtatCrochet.Negatif;
        }
        else
        {
            return EtatCrochet.Fixe;
        }
    }
}
