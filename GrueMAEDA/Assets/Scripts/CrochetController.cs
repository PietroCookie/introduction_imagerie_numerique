using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EtatCrochet { Fixe = 0, Positif = 1, Negatif = -1 };

public class CrochetController : MonoBehaviour
{
    public EtatCrochet translationEtat = EtatCrochet.Fixe;
    public float vitesse = 1.0f;

    private void FixedUpdate()
    {
        if (translationEtat != EtatCrochet.Fixe)
        {
			
        }
    }
}
