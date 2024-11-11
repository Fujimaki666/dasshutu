using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book : MonoBehaviour
{
    [SerializeField] GameObject Nazotoki;
    // [SerializeField] GameObject get_Key;
    [SerializeField] GameObject panel;
    [SerializeField] TextDisplay textDisplay;


    // Start is called before the first frame update

    public void ItemClick()
    {
        
            Debug.Log("aaa");
            Nazotoki.SetActive(true);
            panel.SetActive(true);
        textDisplay.RestartTextDisplay();


    }
    public void ItemClose()
    {
        Debug.Log("bbb");
       
        Nazotoki.SetActive(false);
    }
}
