using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;












public class PlayButton : MonoBehaviour



{

    




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void playbuttonclicked()
    {
        Debug.Log("Play was pressed");
        SceneManager.LoadScene(1);

        
       
       




    }
    public void menubuttonclicked()
    {
        Debug.Log("Menu was pressed");
        SceneManager.LoadScene(0);
    }
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }



}   































      

