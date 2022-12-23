using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Collider))]
public class cshClearButtonEvent : MonoBehaviour
{
    public Image LoadingBar;
    public GameObject Mascotte;
    private Animator m_animator;
    private bool IsOn;
    private float barTime = 0.0f;
    public bool buttonPressed;
    string tag;

    void Start()
    {
        IsOn = false;
        buttonPressed = false;
        LoadingBar = GameObject.FindGameObjectWithTag("LOADINGBAR").GetComponent<Image>();
        LoadingBar.fillAmount = 0;
        m_animator = Mascotte.GetComponent<Animator>();
        m_animator.SetInteger("animBaseInt", 7);
    }

    void Update()
    {

        if (IsOn)
        {
            if (barTime <= 3.0f)
            {
                barTime += Time.deltaTime;
            }
            LoadingBar.fillAmount = barTime / 3.0f;
        }
        //Debug.Log(tag == "bodingButton");
        //Debug.Log(LoadingBar.fillAmount >= 0.999);
        if (tag == "CLOSE" && LoadingBar.fillAmount >= 0.999)
        {
            Debug.Log("Clear Button Pressed");
            buttonPressed = true;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (buttonPressed)
        {
            LoadingBar.fillAmount = 0;
            buttonPressed = false;
            string atom = this.transform.parent.gameObject.name.Split('(')[0];
            Debug.Log(atom);
            switch (atom)
            {
                case "CNTTMI":
                    if (this.transform.parent.position.x > 0)
                    {
                        if (GameObject.FindGameObjectsWithTag("SWCNT").Length < 2)
                        {
                            cshHitAtoms.POSITION = false;
                            Destroy(GameObject.FindGameObjectsWithTag("SWCNT")[0]);
                        }
                        else
                            Destroy(GameObject.FindGameObjectsWithTag("SWCNT")[1]);
                    }
                    else
                    {
                        cshHitAtoms.POSITION = false;
                        Destroy(GameObject.FindGameObjectsWithTag("SWCNT")[0]);
                    }

                    break;
                case "H2OTMI":
                    if (this.transform.parent.position.x > 0)
                    {
                        if (GameObject.FindGameObjectsWithTag("H2O").Length < 2)
                        {
                            cshHitAtoms.POSITION = false;
                            Destroy(GameObject.FindGameObjectsWithTag("H2O")[0]);
                        }
                        else
                            Destroy(GameObject.FindGameObjectsWithTag("H2O")[1]);
                    }
                    else
                    {
                        cshHitAtoms.POSITION = false;
                        Destroy(GameObject.FindGameObjectsWithTag("H2O")[0]);
                    }
                    break;
                case "CO2TMI":
                    if (this.transform.parent.position.x > 0)
                    {
                        if (GameObject.FindGameObjectsWithTag("CO2").Length < 2)
                        {
                            cshHitAtoms.POSITION = false;
                            Destroy(GameObject.FindGameObjectsWithTag("CO2")[0]);
                        }
                        else
                            Destroy(GameObject.FindGameObjectsWithTag("CO2")[1]);
                    }
                    else
                    {
                        cshHitAtoms.POSITION = false;
                        Destroy(GameObject.FindGameObjectsWithTag("CO2")[0]);
                    }
                    break;
                case "C6H12O6TMI":
                    if (this.transform.parent.position.x > 0)
                    {
                        if (GameObject.FindGameObjectsWithTag("C6H12O6").Length < 2)
                        {
                            cshHitAtoms.POSITION = false;
                            Destroy(GameObject.FindGameObjectsWithTag("C6H12O6")[0]);
                        }
                        else
                            Destroy(GameObject.FindGameObjectsWithTag("C6H12O6")[1]);
                    }
                    else
                    {
                        cshHitAtoms.POSITION = false;
                        Destroy(GameObject.FindGameObjectsWithTag("C6H12O6")[0]);
                    }
                    break;

            }
            Destroy(this.transform.parent.gameObject);
        }
    }

    public void SetGazedAt(bool gazedAt)
    {

        IsOn = gazedAt;
        barTime = 0.0f;
        if (gazedAt)
        {
            //Debug.Log(barTime);
            tag = this.gameObject.tag;

        }
        else
        {
            Debug.Log("Out");
            LoadingBar.fillAmount = 0;
            buttonPressed = false;
        }
    }




}
