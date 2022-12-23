using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshFireAtom : MonoBehaviour
{
	cshBondingButtonEvent cshBondingButtonEvent;
	private float atomSpeed = 100.0f;
	private Transform thisTransform;
	// Use this for initialization
	void Start()
	{
		thisTransform = GetComponent<Transform>();
		
	}
	void Update() {
		FireAtom();
	}
	void FireAtom()
	{
		if (GameObject.Find("bondingButton") != null)
		{
			//Debug.Log(GameObject.Find("bondingButton").GetComponent<cshBondingButtonEvent>().buttonPressed);
			if (GameObject.Find("bondingButton").GetComponent<cshBondingButtonEvent>().buttonPressed)
			{
				GetComponent<Rigidbody>().AddForce(thisTransform.forward * atomSpeed);
				GameObject.Find("bondingButton").GetComponent<cshBondingButtonEvent>().buttonGazzed = true;
				//GameObject.Find("bondingButton").GetComponent<cshBondingButtonEvent>().buttonPressed = false;
			}

		}

	}

}
