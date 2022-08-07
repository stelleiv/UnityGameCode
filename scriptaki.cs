using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class scriptaki : MonoBehaviour



{
    
   
    public GameObject Gefira;
    public GameObject epafimeDedro1;
    public GameObject epafimevraxo1;
    public GameObject keimenokatwaristera;
    public GameObject porta;
    
    public GameObject vraxosgefiras;
    string iamlookingat = "nothing";
    bool browbox = false;
    public Kill Maxairi; 
    int metritis = 0;
















    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
            if (iamlookingat == "vraxosgefiras")
            {
                Destroy(vraxosgefiras);
                
               

            }

        }


            if (Input.GetKeyDown(KeyCode.G))
            {
                if (browbox == true)
                {


                    Destroy(epafimevraxo1);


                }


            }

        

    }
    private void FixedUpdate()
    {
        RaycastHit hit;
      
            if(Physics.Raycast(this.gameObject.transform.position,this.gameObject.transform.TransformDirection(Vector3.forward),out hit,20))
        {
            if(hit.collider.name== "vraxosgefiras" && hit.distance<2)
            {
                iamlookingat = "vraxosgefiras";
            }
            Debug.DrawRay(this.gameObject.transform.position, this.gameObject.transform.TransformDirection(Vector3.forward) * 20, Color.green);
            Debug.Log(hit.collider.gameObject.name);

        }
        else
       {
            Debug.DrawRay(this.gameObject.transform.position, this.gameObject.transform.TransformDirection(Vector3.forward) * 20, Color.red);
            Debug.Log("No hit");
            iamlookingat = "nothing";

        }
        
        
            
           
            

    }
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.name == "Dedro1")

        {
            

            Destroy(collision.gameObject);

        }
        
        
        if (collision.gameObject.name == "porta")
        {
            porta.GetComponent<Animation>().Play("open");
        }
        if(collision.gameObject.name == "kranio")
        {
            porta.GetComponent<Animation>().Play("close");
        }












            if (collision.gameObject.name == "maxairi")
        {
            Destroy(collision.gameObject);

            metritis = metritis + 1;

            

            Debug.Log("Posa maxairia  exw" + metritis);

            keimenokatwaristera.GetComponent<TextMeshProUGUI>().text = "maxairi" + metritis;

            if (metritis == 3)
            {
                Maxairi.PetawMaxairi = true;

                keimenokatwaristera.GetComponent<TextMeshProUGUI>().text = "Go into the red box,destroy the rock (press the left mouse button) and pass the river";

            }




        }




    }
    void OnTriggerEnter(Collider other)
        
    {
        if (other.gameObject.name == "brownbox")

        {
            keimenokatwaristera.GetComponent<TextMeshProUGUI>().text = "press the G button inside the brown box";
            browbox= true;
            Debug.Log("brownbox" + browbox);

        }
        {
            if (other.gameObject.name == "brownarea")


            {
                if (metritis==3)
                {
                    Gefira.SetActive(true);

                }

            }
            
        }
        if (other.gameObject.name == "greenarea")
        {
            Gefira.SetActive(false);
            
            keimenokatwaristera.GetComponent<TextMeshProUGUI>().text = "Go close to the Tiger, press E and use three knives.Kill her and go into the house";

            

        }
        
        







    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "brownbox")
        {
            browbox = false;

            Debug.Log("brownbox" + browbox);
            
            keimenokatwaristera.GetComponent<TextMeshProUGUI>().text = "touch the fallen tree  after leaving the green box";


        }

        if (other.gameObject.name == "greenbox")
      {
            
          
            Destroy(epafimeDedro1);
           
            keimenokatwaristera.GetComponent<TextMeshProUGUI>().text = "pick up three knives and activate the bridge";


        }
    }
   

}


















