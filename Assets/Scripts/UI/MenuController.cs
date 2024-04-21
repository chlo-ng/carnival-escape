using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;

    // Function for Button1 to toggle between Panel 1 and Panel 2
    public void TogglePanel1()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
    }

    // Function for Button2 to toggle between Panel 2 and Panel 1
    public void TogglePanel2()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
    }
}

