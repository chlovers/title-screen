using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject Mainmenu;
    public GameObject OptionsMenu;
    public GameObject gameplay;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
 

    public void Shutoff()
    {
        Mainmenu.SetActive(false);
        OptionsMenu.SetActive(false);
        gameplay.SetActive(false);
    }

    private void Start()
    {
        Shutoff();
        Mainmenu.SetActive(true);
    }
    // Update is called once per frame
    public void mainstart()
    {
        Shutoff();
        Mainmenu.SetActive(true);
    }

    public void optionsscreen()
    {
        Shutoff();
        OptionsMenu.SetActive(true);


    }

    public void gameplayscene()
    {
        Shutoff();
        gameplay.SetActive(true);

    }

    public void quitbutton()
    {
        Application.Quit();

    }
}
