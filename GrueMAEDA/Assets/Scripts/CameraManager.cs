using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    
	public Camera Cam3Per;
	public Camera CamPilot;
	public Camera CamGlobal;

    // Start is called before the first frame update
    void Start()
    {
		Cam3Per.enabled = false;
        CamPilot.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
		// Cam Global
		if(Input.GetKey(KeyCode.Alpha1)) {
			CamPilot.enabled = false;
			Cam3Per.enabled = false;
			CamGlobal.enabled = true;
			CamGlobal.rect = new Rect(0, 0, 1, 1);
		}

		// Cam 3eme person
		if(Input.GetKey(KeyCode.Alpha2)) {
			CamPilot.enabled = false;
			CamGlobal.enabled = false;
			Cam3Per.enabled = true;
			Cam3Per.rect = new Rect(0, 0, 1, 1);
		}

		// Cam cabine
        if(Input.GetKey(KeyCode.Alpha3)) {
			CamPilot.enabled = true;
			Cam3Per.enabled = false;
			CamGlobal.enabled = false;
			CamPilot.rect = new Rect(0, 0, 1, 1);
		}

		// Double view
		if(Input.GetKey(KeyCode.Alpha4)) {
			CamPilot.enabled = true;
			Cam3Per.enabled = true;
			CamGlobal.enabled = false;
			Cam3Per.rect = new Rect(0, 0, 0.5f, 1);
			CamPilot.rect = new Rect(0.5f, 0, 0.5f, 1);
		}

		// Triple view
		if(Input.GetKey(KeyCode.Alpha5)) {
			CamPilot.enabled = true;
			Cam3Per.enabled = true;
			CamGlobal.enabled = true;
			CamGlobal.rect = new Rect(0, 0, 1, 0.5f);
			Cam3Per.rect = new Rect(0, 0.5f, 0.5f, 0.5f);
			CamPilot.rect = new Rect(0.5f, 0.5f, 0.5f, 0.5f);
		}
    }
}
