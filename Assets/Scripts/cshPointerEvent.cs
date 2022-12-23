using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Collider))]
public class cshPointerEvent : MonoBehaviour
{
    public Image LoadingBar;
    public Image LoadingBar2;
    public Transform H;
    public Transform He;
    public Transform Li;
    public Transform Be;
    public Transform B;
    public Transform C;
    public Transform N;
    public Transform O;
    public Transform F;
    public Transform Ne;
    public Transform Na;
    public Transform Mg;
    public Transform startPos1;
    public Transform startPos2;
    public Transform startPos3;
    public Transform startPos4;

    private bool IsOn;
    private float barTime = 0.0f;
    private float barTime2 = 0.0f;


    public static bool AtomGenerated;
    public static int AtomGenerated_C;
    public static bool AtomGenerated2;
    public static bool AtomGenerated_C_bool;
    string tag;

    void Start()
    {
        IsOn = false;
        AtomGenerated = false;
        AtomGenerated2 = false;
        AtomGenerated_C = 2;
        AtomGenerated_C_bool = false;
        LoadingBar.fillAmount = 0;
        tag = null;
    }

    void Update()
    {

        if (IsOn)
        {
            if (barTime <= 3.0f)
            {
                barTime += Time.deltaTime;
            }
            if (!AtomGenerated_C_bool)
                LoadingBar.fillAmount = barTime / 3.0f;
            if (barTime2 <= 10.0f && AtomGenerated_C_bool)
            {
                barTime2 += Time.deltaTime;
                LoadingBar.fillAmount = barTime2 / 3.0f;
            }

        }
        //Debug.Log(LoadingBar.fillAmount);
        if (cshHitAtoms.POSITION == false)
        {
            if (LoadingBar.fillAmount == 1)
            {


                switch (tag)
                {

                    case "H":
                        Debug.Log("pos false:"+tag);
                        if (!AtomGenerated)
                        {
                            Instantiate(H, startPos1.position, startPos1.rotation);
                            AtomGenerated = true;
                            cshAtomInformation.choice1 = 1;
                        }
                        //tag = null;
                        break;
                    case "He":
                        break;
                    case "Li":
                        break;
                    case "Be":
                        break;
                    case "B":
                        break;
                    case "C":
                        Debug.Log("pos false:" + tag);
                        Debug.Log("AtomGenerated_C_bool:" + AtomGenerated_C_bool);
                        Debug.Log("AtomGenerated_C : " + AtomGenerated_C);
                        if (!AtomGenerated)
                        {
                            Instantiate(C, startPos1.position, startPos1.rotation);
                            AtomGenerated = true;
                            AtomGenerated_C--;
                            cshAtomInformation.choice1 = -4;
                            AtomGenerated_C_bool = true;
                            Debug.Log("AtomGenerated_C_bool2 :" + AtomGenerated_C_bool);
                            LoadingBar.fillAmount = barTime2 / 6.0f;
                        }
                        else if (AtomGenerated_C_bool && LoadingBar.fillAmount == 1 && AtomGenerated_C > 0)
                        {

                            Instantiate(C, startPos2.position, startPos2.rotation);
                            AtomGenerated = true;
                            AtomGenerated_C--;
                            cshAtomInformation.choice2 = -4;
                            AtomGenerated_C_bool = false;
                        }
                        //tag = null;
                        break;
                    case "N":
                        break;
                    case "O":
                        Debug.Log("pos false:" + tag);
                        if (!AtomGenerated2)
                        {
                            Instantiate(O, startPos2.position, startPos2.rotation);
                            AtomGenerated2 = true;
                            cshAtomInformation.choice2 = -2;
                        }
                        //tag = null;
                        break;
                    case "F":
                        break;
                    case "Ne":
                        break;
                    case "Na":
                        break;
                    case "Mg":
                        break;
                    default:

                        break;
                }
            }
        }
        else {
            if (LoadingBar.fillAmount == 1)
            {


                switch (tag)
                {

                    case "H":
                        Debug.Log("pos true:" + tag);
                        if (!AtomGenerated)
                        {
                            Instantiate(H, startPos3.position, startPos3.rotation);
                            AtomGenerated = true;
                            cshAtomInformation.choice1 = 1;
                        }
                        //tag = null;
                        break;
                    case "He":
                        break;
                    case "Li":
                        break;
                    case "Be":
                        break;
                    case "B":
                        break;
                    case "C":
                        Debug.Log("pos true:" + tag);
                        Debug.Log("AtomGenerated_C_bool:" + AtomGenerated_C_bool);
                        if (!AtomGenerated)
                        {
                            Instantiate(C, startPos3.position, startPos3.rotation);
                            AtomGenerated = true;
                            AtomGenerated_C--;
                            cshAtomInformation.choice1 = -4;
                            AtomGenerated_C_bool = true;
                            LoadingBar.fillAmount = barTime2 / 6.0f;
                        }
                        else if (AtomGenerated_C_bool && LoadingBar.fillAmount == 1 && AtomGenerated_C > 0)
                        {

                            Instantiate(C, startPos4.position, startPos4.rotation);
                            AtomGenerated = true;
                            AtomGenerated_C--;
                            cshAtomInformation.choice2 = -4;
                            AtomGenerated_C_bool = false;
                        }
                        //tag = null;
                        break;
                    case "N":
                        break;
                    case "O":
                        Debug.Log("pos true:" + tag);
                        if (!AtomGenerated2)
                        {
                            Instantiate(O, startPos4.position, startPos4.rotation);
                            AtomGenerated2 = true;
                            cshAtomInformation.choice2 = -2;
                        }
                        //tag = null;
                        break;
                    case "F":
                        break;
                    case "Ne":
                        break;
                    case "Na":
                        break;
                    case "Mg":
                        break;
                    default:

                        break;
                }
            }
        }


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    void onColliderEnter(Collider coll)
    {

        switch (coll.gameObject.tag)
        {

            default:
                //Debug.Log(coll.gameObject.tag);
                break;

        }

    }
    public void SetGazedAt(bool gazedAt)
    {

        IsOn = gazedAt;
        barTime = 0.0f;
        barTime2 = 0.0f;
        if (gazedAt)
        {

            //Debug.Log(barTime);
            tag = this.gameObject.tag;
            //         if (LoadingBar.fillAmount == 100)
            //         {
            //                Debug.Log(tag);
            //
            //                switch (tag)
            //            {
            //                    case "H" :
            //
            //                        break;
            //                    case "He":
            //                        break;
            //            }
            //         }
        }
        else
        {
            Debug.Log("Out");
            AtomGenerated_C_bool = false;
            LoadingBar.fillAmount = 0;
            tag = null;
        }
    }

}
