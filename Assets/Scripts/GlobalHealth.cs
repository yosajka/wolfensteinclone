using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour
{
    public GameObject healthDisplay;
    public static int healthValue;
    public int internalHealth;

    public GameObject hp100;
    public GameObject hp75;
    public GameObject hp50;
    public GameObject hp25;
   
    void Start()
    {
        healthValue = 100;
    }

    void DislayAvatar()
    {
        if (healthValue < 25)
        {
            hp25.SetActive(true);
            hp50.SetActive(false);
            hp75.SetActive(false);
            hp100.SetActive(false);

        }
        else if (healthValue >= 25 && healthValue < 50)
        {
            hp25.SetActive(false);
            hp50.SetActive(true);
            hp75.SetActive(false);
            hp100.SetActive(false);
        }
        else if (healthValue >= 50 && healthValue < 75)
        {
            hp25.SetActive(false);
            hp50.SetActive(false);
            hp75.SetActive(true);
            hp100.SetActive(false);
        }
        else
        {
            hp25.SetActive(false);
            hp50.SetActive(false);
            hp75.SetActive(false);
            hp100.SetActive(true);
        }
    }

    
    void Update()
    {
        if (healthValue <= 0)
        {
            SceneManager.LoadScene("LevelRecycle");
        }
        internalHealth = healthValue;
        healthDisplay.GetComponent<Text>().text = healthValue.ToString() + "%";

        DislayAvatar();
    }
}
