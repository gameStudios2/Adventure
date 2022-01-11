using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Save : MonoBehaviour
{
    public Transform ptrans;
    int ppX = 0;
    int ppY = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ppX = (int)ptrans.position.x;
        ppY = (int)ptrans.position.y;

        
    }

    public void SaveNew()
    {
            PlayerPrefs.SetInt("px", ppX);
            PlayerPrefs.SetInt("py", ppY);

            PlayerPrefs.Save();
    }

    public void LoadSaved()
    {

        if (PlayerPrefs.HasKey("px") || PlayerPrefs.HasKey("py"))
        {
            ppX = PlayerPrefs.GetInt("px");
            ppY = PlayerPrefs.GetInt("py");
            ptrans.position = (new Vector2(ppX, ppY));
        }
    }

    public void NewGame()
    {
        SceneManager.LoadScene("Tutorial");
        ptrans.position = (new Vector2(0, 0));
    }
    
}
