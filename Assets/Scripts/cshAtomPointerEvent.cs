using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Collider))]
public class cshAtomPointerEvent : MonoBehaviour
{


    public Image LoadingBar;


    private bool IsOn;
    private float barTime = 0.0f;
    string tag;

    void Start()
    {
        IsOn = false;
        LoadingBar = LoadingBar = GameObject.FindGameObjectWithTag("LOADINGBAR").GetComponent<Image>();
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
            //LoadingBar.fillAmount = barTime / 3.0f;
            this.transform.Rotate(0.0f, 90.0f * Time.deltaTime, 0.0f);
        }
        //Debug.Log(tag == "bodingButton");
        //Debug.Log(LoadingBar.fillAmount >= 0.999);
       

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
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
        }
    }




}
