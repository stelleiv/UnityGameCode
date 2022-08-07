using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Kill : MonoBehaviour
{
    public GameObject Lepida;
    public GameObject Tiger;


    bool lepida ;
    public bool PetawMaxairi = false;

    
    int metritis = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && PetawMaxairi == true)
        {
            GameObject bullettemp = Instantiate(Lepida, this.gameObject.transform.position, this.gameObject.transform.rotation);
            bullettemp.GetComponent<Rigidbody>().AddForce(bullettemp.gameObject.transform.forward * 500);
            metritis = metritis + 1;
          Debug.Log("Poses lepides exw" + metritis);
            
            if (metritis == 3)
            {

                
                Destroy(Tiger);

                Lepida.SetActive(false);
                    
            }


        }
        
    
     }
}
