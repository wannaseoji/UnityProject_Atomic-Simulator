using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider))]
public class cshButtonPointerEvent : MonoBehaviour
{
    public Image LoadingBar;
    public GameObject Mascotte;
    private Animator m_animator;
    private bool IsOn;
    private float barTime = 0.0f;
    void Start()
    {
        IsOn = false;
        LoadingBar.fillAmount = 0;
        m_animator = Mascotte.GetComponent<Animator>();
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
            if (barTime > 3.0f)
            {
                if (this.gameObject.tag == "YESBUTTON")
                    SceneManager.LoadScene("SimulationScene");
                if (this.gameObject.tag == "NOBUTTON")
                    Quit();
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Quit();
        }
    }
    public void SetGazedAt(bool gazedAt)
    {
        IsOn = gazedAt;
        barTime = 0.0f;
        if (gazedAt)
        {
            Debug.Log("In");
            if (this.gameObject.tag == "YESBUTTON")
                m_animator.SetInteger("animBaseInt", 6);
            if (this.gameObject.tag == "NOBUTTON")
                m_animator.SetInteger("animBaseInt", 2);
        }
        else
        {
            Debug.Log("Out");
            LoadingBar.fillAmount = 0;
            m_animator.SetInteger("animBaseInt", 9);
        }
    }
    private void Quit()
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #elif UNITY_WEBPLAYER
         Application.OpenURL("http://google.com");
    #else
         Application.Quit();
    #endif
    }
}
