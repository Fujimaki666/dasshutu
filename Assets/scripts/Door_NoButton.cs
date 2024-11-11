using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_NoButton : MonoBehaviour
{
    [SerializeField] GameObject button1;
    [SerializeField] GameObject button2;
    // Start is called before the first frame update
    public void OnClick()
    {
       
        button1.SetActive(false);
        button2.SetActive(false);

       
        Debug.Log("‰Ÿ‚³‚ê‚½!");  // ƒƒO‚ğo—Í

    }
}
