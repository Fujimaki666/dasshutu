using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class window : MonoBehaviour
{
    // [SerializeField] GameObject get_Key;
    [SerializeField] GameObject panel_window;
    [SerializeField] TextDisplay textDisplay;
    public void ItemClick()
    {
       
            panel_window.SetActive(true);
            textDisplay.RestartTextDisplay();


    }
    public void ItemClose()
    {

        panel_window.SetActive(false);


    }

}
