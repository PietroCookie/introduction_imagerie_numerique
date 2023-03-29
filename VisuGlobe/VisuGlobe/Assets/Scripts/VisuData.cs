using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisuData : MonoBehaviour
{
    public Transform Cible;
	public GameObject VisuCube;
	public float multiplier;

	Vector3 latloncart(float lat, float lon)
	{
		Vector3 pos;
		float x = 0.5f * Mathf.Cos(lon) * Mathf.Cos(lat);
		float y = 0.5f * Mathf.Cos(lon) * Mathf.Sin(lat);
		float z = 0.5f * Mathf.Sin(lon);
		pos.x = 0.5f * Mathf.Cos((lon) * Mathf.Deg2Rad) * Mathf.Cos(lat * Mathf.Deg2Rad);
		pos.y = 0.5f * Mathf.Sin(lat * Mathf.Deg2Rad);
		pos.z = 0.5f * Mathf.Sin((lon) * Mathf.Deg2Rad) * Mathf.Cos(lat * Mathf.Deg2Rad);
		return pos;
	}

	public void VisualCube (float lat, float lon, float val, float multiplier)
{	
		GameObject cube = GameObject.Instantiate(VisuCube);
		Vector3 pos;
		pos = latloncart(lat, lon);
		cube.transform.position = new Vector3(pos.x, pos.y, pos.z);
		cube.transform.LookAt(Cible, Vector3.back);
		Vector3 echelle = cube.transform.localScale;
		echelle.z = val*multiplier;
		cube.transform.localScale = echelle;
	}
}
