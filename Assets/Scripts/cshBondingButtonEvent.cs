using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Collider))]
public class cshBondingButtonEvent : MonoBehaviour
{


    public Image LoadingBar;

    public bool buttonGazzed;
    private bool IsOn;
    private float barTime = 0.0f;
    public bool buttonPressed ;
    string tag;

    void Start()
    {
        IsOn = false;
        buttonPressed = false;
        buttonGazzed = false;
        LoadingBar = GameObject.FindGameObjectWithTag("LOADINGBAR").GetComponent<Image>();
        LoadingBar.fillAmount = 0;
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
        if (tag=="bondingButton" && LoadingBar.fillAmount >= 0.999)
        {
            Debug.Log("bondingButton set True");
            buttonPressed = true;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
		if (buttonGazzed)
		{
            LoadingBar.fillAmount = 0;
            buttonPressed = false;
            Destroy(this.transform.parent.gameObject, .5f);
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
