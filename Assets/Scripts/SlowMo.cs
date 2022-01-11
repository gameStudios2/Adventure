using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMo : MonoBehaviour
{
    public float time = 0.05f;
    public float time1 = 1f;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Time.timeScale = time;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            Time.timeScale = time1;
        }
    }
}
