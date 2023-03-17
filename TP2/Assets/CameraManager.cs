using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
	public Camera CamGlobal;
	public Camera CamCabine;

    // Start is called before the first frame update
    void Start()
    {
        CamCabine.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
		// Cam Global
		if(Input.GetKey(KeyCode.Alpha1)) {
			CamCabine.enabled = false;
			CamGlobal.enabled = true;
		}

		// Cam cabine
        if(Input.GetKey(KeyCode.Alpha2)) {
			CamCabine.enabled = true;
			CamGlobal.enabled = false;
		}
    }
}
