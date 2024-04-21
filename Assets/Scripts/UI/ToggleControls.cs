using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleControls : MonoBehaviour
{
    private GameObject mainmenu;
    private GameObject controls;

    void Awake()
    {
        controls = GameObject.Find("ControlsPanel");
        controls.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        mainmenu = GameObject.Find("MainMenu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowControls()
    {
        controls.SetActive(!controls.activeSelf);
        mainmenu.SetActive(!mainmenu.activeSelf);
    }
}
