using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshBoomDestory : MonoBehaviour
{
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (time <= 1.8f)
        {
            time += Time.deltaTime;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}