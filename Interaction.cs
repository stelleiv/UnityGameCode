using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interaction : MonoBehaviour
{
    public GameObject Maxairi;
    public string TiVlepw;


    int metritis = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("apothikeumenosmetritis", 0) == 3)
        {
            SceneManager.LoadScene(1);
        }
        if (PlayerPrefs.GetInt("apothikeumenosmetritis", 0) !=0)
        {
            Debug.Log("Tin proigoumeni fora pires:" + PlayerPrefs.GetInt("apothikeumenosmetritis", 0) + "maxairi");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Maxairi" && TiVlepw == "Maxairi")
        {
            Destroy(collision.gameObject);
            metritis = metritis + 1;
            PlayerPrefs.SetInt("apothikeumenosmetritis", metritis);
            Debug.Log(metritis);
            if (metritis == 3)
            {
                SceneManager.LoadScene(0);
            }
              

        }

    }
}
