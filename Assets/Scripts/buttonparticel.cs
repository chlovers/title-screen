using UnityEngine;

public class buttonparticel : MonoBehaviour
{
    public GameObject startbutton;
   public GameObject optionsbutton;
   public GameObject quitbutton;
   public GameObject returnbutton;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startbutton.SetActive(false);
      optionsbutton.SetActive(false);
        quitbutton.SetActive(false);
		returnbutton.SetActive(false);
    }
    public void nosparkel()
    {
        startbutton.SetActive(false);
       optionsbutton.SetActive(false);
     quitbutton.SetActive(false);
	 returnbutton.SetActive(false);

    }
    // Update is called once per frame
  public void starthover()
    {
        nosparkel();
        startbutton.SetActive(true);

    }

  public void optionshover()
    {
        nosparkel();
      optionsbutton.SetActive(true);

    }

    public void quithover()
    {
        nosparkel();
       quitbutton.SetActive(true);
}
	public void returnhover()
	{
		nosparkel();
		returnbutton.SetActive(true);
	}

}
