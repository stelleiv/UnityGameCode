using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour
 
{
    [SerializeField] GameObject FlashLightLight;
    private bool Flashlightactive = false; 

    // Start is called before the first frame update
    void Start()
    {
        FlashLightLight.gameObject.SetActive(true);


            
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
