using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terevi : MonoBehaviour
{
    //public bool isPushed = false;
    [SerializeField] GameObject Tegata;
    // [SerializeField] GameObject get_Key;
    [SerializeField] GameObject panel;
    // public Item.Type type = default;
    // Start is called before the first frame update
    //private bool hasClicked = false;
    //private AudioSource sound;

    
    public void ItemClick()
    {
        
            
           
            
            Tegata.SetActive(true);
            //panel.SetActive(true);
         
         

    }
}
