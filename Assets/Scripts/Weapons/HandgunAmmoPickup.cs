using UnityEngine;
using UnityEngine.UI;

public class HandgunAmmoPickup : MonoBehaviour
{
    //public GameObject realGun;
    public AudioSource pickupFX;
    public GameObject pickUpDisplay;

    void OnTriggerEnter()
    {
        pickupFX.Play();
        gameObject.SetActive(false);
        GlobalAmmo.numAmmo += 10;

        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<Text>().text = "CLIP OF BULLETS";
        pickUpDisplay.SetActive(true);
    }
}
