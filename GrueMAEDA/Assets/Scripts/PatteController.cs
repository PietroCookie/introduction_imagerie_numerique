using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EtatPatteRotation { Fixe = 0, Positif = 1, Negatif = -1 };


public class PatteController : MonoBehaviour
{
    public EtatPatteRotation rotationEtat = EtatPatteRotation.Fixe;
    public float vitesse;

    private ArticulationBody articulation;

    void Start()
    {
        articulation = GetComponent<ArticulationBody>();
    }

    void FixedUpdate()
    {
        if (rotationEtat != EtatPatteRotation.Fixe)
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
        var drive = articulation.zDrive;
        drive.target = primaryAxisRotation;
        articulation.zDrive = drive;
    }
}
