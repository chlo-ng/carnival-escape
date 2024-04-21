using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMenu : MonoBehaviour
{
    private GameObject mainmenu;
    private GameObject controls; 

    // Start is called before the first frame update
    void Start()
    {
        mainmenu = GameObject.Find("MainMenu");
        controls = GameObject.Find("Controls");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowMenu()
    {
        controls.SetActive(!controls.activeSelf);
        mainmenu.SetActive(!mainmenu.activeSelf);
    }
}
