using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EtatPatteDeploiement { Fixe = 0, Positif = 1, Negatif = -1 };


public class PatteDeploiementController : MonoBehaviour
{
    public EtatPatteDeploiement rotationEtat = EtatPatteDeploiement.Fixe;
    public float vitesse = 30.0f;

    private ArticulationBody articulation;

    void Start()
    {
        articulation = GetComponent<ArticulationBody>();
    }

    void FixedUpdate()
    {
        if (rotationEtat != EtatPatteDeploiement.Fixe)
        {
            float rotationChange = (float)rotationEtat * vitesse * Time.fixedDeltaTime;
            float rotationGoal = AxeRotation() + rotationChange;
            RotationVers(rotationGoal);
        }


    }

    float AxeRotation()
    {
        float RotationRads = articulation.jointPosition[0];
        float Rotation = Mathf.Rad2Deg * RotationRads;
        return Rotation;
    }

    void RotationVers(float primaryAxisRotation)
    {
        var drive = articulation.yDrive;
        drive.target = primaryAxisRotation;
        articulation.yDrive = drive;
    }
}
