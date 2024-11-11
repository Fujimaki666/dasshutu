using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toire_unti : MonoBehaviour
{
    [SerializeField] GameObject Unti;
    [SerializeField] GameObject get_Unti;
    [SerializeField] GameObject panel1;
    [SerializeField] TextDisplay textDisplay;

    // Start is called before the first frame update
    public void ItemClick()
    {
        Debug.Log("aaa");
        Unti.SetActive(true);
        panel1.SetActive(true);
        textDisplay.RestartTextDisplay();
    }
    public void ItemClose()
    {
        Debug.Log("bbb");
        Unti.SetActive(false);
        get_Unti.SetActive(true);
        textDisplay.RestartTextDisplay();
    }
}
