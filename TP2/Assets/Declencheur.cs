using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Declencheur : MonoBehaviour
{
	public TMP_Text txtCount;
	private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

	private void OnTriggerEnter(Collider Collision)
	{
		if (Collision.gameObject.tag == "Charge")
		{
			count++;
			txtCount.text = count.ToString("00");
			Debug.Log("Declenché");
			Destroy(Collision.gameObject);
		}
	}

    // Update is called once per frame
    void Update()
    {
		
    }
}
