using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitokage : MonoBehaviour
{
    
    [SerializeField] GameObject panel_hitokage;
    // Start is called before the first frame update
    public void ItemClick()
    {
        panel_hitokage.SetActive(true);

    }
   
}
