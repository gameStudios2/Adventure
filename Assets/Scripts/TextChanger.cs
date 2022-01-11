using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    public Text txt;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        txt.text = time.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        txt.text = Mathf.Round(time).ToString();
        if(time == -1)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
