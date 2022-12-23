using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshFireMolecule: MonoBehaviour
{
	cshBondingButtonEvent cshBondingButtonEvent;
	private float atomSpeed = 100.0f;
	private Transform thisTransform;
	// Use this for initialization
	void Start()
	{
		thisTransform = GetComponent<Transform>();

	}
	void Update()
	{
		FireAtom();
	}
	void FireAtom()
	{
		if (GameObject.Find("moleculebondingButton") != null)
		{
			//Debug.Log(GameObject.Find("bondingButton").GetComponent<cshBondingButtonEvent>().buttonPressed);
			if (GameObject.Find("moleculebondingButton").GetComponent<cshMoleculeBondingButton>().buttonPressed)
			{
				GetComponent<Rigidbody>().AddForce(thisTransform.forward * atomSpeed);
				GameObject.Find("moleculebondingButton").GetComponent<cshMoleculeBondingButton>().buttonGazzed = true;
				//GameObject.Find("bondingButton").GetComponent<cshBondingButtonEvent>().buttonPressed = false;
			}

		}

	}

}
