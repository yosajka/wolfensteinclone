using UnityEngine.UI;
using UnityEngine;

public class FirstAidCollect : MonoBehaviour
{
    public AudioSource pickupFX;
    public GameObject pickUpDisplay;

    void OnTriggerEnter()
    {
        GlobalHealth.healthValue = 100;
        pickupFX.Play();
        transform.parent.gameObject.SetActive(false);
        
        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<Text>().text = "FIRST-AID KIT USED";
        pickUpDisplay.SetActive(true);
    }
}
