using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement : MonoBehaviour
{

	// Start is called before the first frame update
    void Start()
	{
 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S)) // Si la touche 'S' est enfoncée alors recule le personnage
		{
			if(Input.GetKey(KeyCode.LeftShift)){ // Vérifie si la touche shift gauche est enfoncé
				transform.Translate(Vector3.forward * 0.01f); // Avance 2 fois plus vite que la vitesse normale
			}else{
				transform.Translate(Vector3.forward * 0.005f); // Avance à la vitesse normale
			}
		}

		if (Input.GetKey(KeyCode.Z)) // Si la touche 'Z' est enfoncée alors avance le personnage
		{
			if(Input.GetKey(KeyCode.LeftShift)){ // Vérifie si la touche shift gauche est enfoncé
				transform.Translate(Vector3.back * 0.01f); // Avance 2 fois plus vite que la vitesse normale
			}else{
				transform.Translate(Vector3.back * 0.005f); // Avance à la vitesse normale
			}
		}

		if (Input.GetKey(KeyCode.Q)) // Si la touche 'Q' est enfoncée alors fais touner le personnage sur la gauche
		{
			transform.Rotate(Vector3.up, -0.5f);
		}

		if (Input.GetKey(KeyCode.D)) // Si la touche 'D' est enfoncée alors fais tourner le personnage sur la droite
		{
			transform.Rotate(Vector3.up, 0.5f);
		}

		if (Input.GetKey(KeyCode.Space)) // Si la touche 'espace' est enfoncée alors fais sauter le personnage
		{
			bool isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f, LayerMask.GetMask("Ground")); // vérifie si le personnage est sur le sol
			
			if(isGrounded){ // Si le personnage est au sol alors ajoute une force au joueur correspondant au vecteur (0,10,0)
				GetComponent<Rigidbody>().AddForce(transform.up * 10);
			}
		}
    }
}
