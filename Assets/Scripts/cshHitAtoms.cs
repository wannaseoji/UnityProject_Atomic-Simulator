using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshHitAtoms : MonoBehaviour
{
	public int hitAtomNum_H2O = 2;
	public int hitAtomNum_CO2 = 2;
	public int hitAtomNum_C = 2;

	public Transform H2O;
	public Transform CO2;
	public Transform C6H12O6	;
	public Transform SWCNT;
	public Transform Boom;
	
	public Transform AtomPos;
	public Transform AtomPos2;
	public Transform BoomPos;
	public Transform BoomPos2;
	public Transform TMIPos;
	public Transform TMIPos2;


	public Transform H2OTMI;
	public Transform CO2TMI;
	public Transform C6H12O6TMI;
	public Transform SWCNTTMI;
	public Transform CO2H2O;
	public Transform CO2H2OPos;


	public static bool POSITION ;

	void Start()
	{
		POSITION = false;
	}
    // Update is called once per frame
    void Update()
	{
        
	}


	void OnTriggerEnter(Collider coll)
	{
		if (POSITION == false)
		{
			Debug.Log(AtomPos.position);
			//AtomPos.position = GameObject.Find("Cube").transform.position;
			Debug.Log(cshAtomInformation.choice1);
			Debug.Log(cshAtomInformation.choice2);
			Debug.Log(cshAtomInformation.choice3);
			Debug.Log(cshAtomInformation.choice4);
			if (cshAtomInformation.choice3 == -4 && cshAtomInformation.choice4 == -4)
			{
				hitAtomNum_C -= 1;
				Destroy(coll.gameObject);
				if (hitAtomNum_C == 0)
				{
					Instantiate(Boom, BoomPos.position, BoomPos.rotation);
					Instantiate(SWCNTTMI, TMIPos.position, TMIPos.rotation);
					Instantiate(SWCNT, AtomPos.position, AtomPos.rotation);
					hitAtomNum_C = 2;
					POSITION = true;
					cshAtomInformation.choice3 = 0;
					cshAtomInformation.choice4 = 0;
				}
			}
			else if (coll.gameObject.name.Substring(0, 5) == "pre_C" || coll.gameObject.name.Substring(0, 5) == "pre_O")
			{
				hitAtomNum_CO2 -= 1;
				Destroy(coll.gameObject);
				if (hitAtomNum_CO2 == 0)
				{
					Instantiate(Boom, BoomPos.position, BoomPos.rotation);
					Instantiate(CO2TMI, TMIPos.position, TMIPos.rotation);

					Instantiate(CO2, AtomPos.position, AtomPos.rotation);
					if (GameObject.FindGameObjectWithTag("H2OTMI") != null && GameObject.FindGameObjectWithTag("CO2TMI") != null)
						Instantiate(CO2H2O, CO2H2OPos.position, CO2H2OPos.rotation);
					POSITION = true;
					hitAtomNum_CO2 = 2;
				}

			}
			if (coll.gameObject.name.Substring(0, 5) == "pre_H" || coll.gameObject.name.Substring(0, 5) == "pre_O")
			{
				hitAtomNum_H2O -= 1;
				Destroy(coll.gameObject);
				if (hitAtomNum_H2O == 0)
				{
					Instantiate(Boom, BoomPos.position, BoomPos.rotation);
					Instantiate(H2OTMI, TMIPos.position, TMIPos.rotation);
					Instantiate(H2O, AtomPos.position, AtomPos.rotation);
					if (GameObject.FindGameObjectWithTag("H2OTMI") != null && GameObject.FindGameObjectWithTag("CO2TMI") != null)
						Instantiate(CO2H2O, CO2H2OPos.position, CO2H2OPos.rotation);
					hitAtomNum_H2O = 2;
					POSITION = true;
				}

			}
			cshPointerEvent.AtomGenerated = false;
			cshPointerEvent.AtomGenerated2 = false;
			cshPointerEvent.AtomGenerated_C = 2;
			cshPointerEvent.AtomGenerated_C_bool = false;
		}
		else
		{
			if (cshAtomInformation.choice3 == -4 && cshAtomInformation.choice4 == -4)
			{
				hitAtomNum_C -= 1;
				Destroy(coll.gameObject);
				if (hitAtomNum_C == 0)
				{
					Instantiate(Boom, BoomPos2.position, BoomPos2.rotation);
					Instantiate(SWCNTTMI, TMIPos2.position, TMIPos2.rotation);
					Instantiate(SWCNT, AtomPos.position, AtomPos.rotation);
					hitAtomNum_C = 2;
					POSITION = true;
					cshAtomInformation.choice3 = 0;
					cshAtomInformation.choice4 = 0;
				}
			}
			else if (coll.gameObject.name.Substring(0, 5) == "pre_C" || coll.gameObject.name.Substring(0, 5) == "pre_O")
			{
				hitAtomNum_CO2 -= 1;
				Destroy(coll.gameObject);
				if (hitAtomNum_CO2 == 0)
				{
					Instantiate(Boom, BoomPos2.position, BoomPos2.rotation);
					Instantiate(CO2TMI, TMIPos2.position, TMIPos2.rotation);
					Instantiate(CO2, AtomPos.position, AtomPos.rotation);
					if (GameObject.FindGameObjectWithTag("H2OTMI") != null && GameObject.FindGameObjectWithTag("CO2TMI") != null)
						Instantiate(CO2H2O, CO2H2OPos.position, CO2H2OPos.rotation);
					POSITION = true;
					hitAtomNum_CO2 = 2;
				}

			}
			if (coll.gameObject.name.Substring(0, 5) == "pre_H" || coll.gameObject.name.Substring(0, 5) == "pre_O")
			{
				hitAtomNum_H2O -= 1;
				Destroy(coll.gameObject);
				if (hitAtomNum_H2O == 0)
				{
					Instantiate(Boom, BoomPos2.position, BoomPos2.rotation);
					Instantiate(H2OTMI, TMIPos2.position, TMIPos2.rotation);
					Instantiate(H2O, AtomPos.position, AtomPos.rotation);
					if(GameObject.FindGameObjectWithTag("H2OTMI")!=null&&GameObject.FindGameObjectWithTag("CO2TMI")!=null)
						Instantiate(CO2H2O, CO2H2OPos.position, CO2H2OPos.rotation);
					hitAtomNum_H2O = 2;
					POSITION = true;
				}

			}
			cshPointerEvent.AtomGenerated = false;
			cshPointerEvent.AtomGenerated2 = false;
			cshPointerEvent.AtomGenerated_C = 2;
			cshPointerEvent.AtomGenerated_C_bool = false;
		}
	}







}
