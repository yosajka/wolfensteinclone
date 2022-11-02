using UnityEngine;
using UnityEngine.UI;

public class GunPickup : MonoBehaviour
{
    public GameObject realGun;
    public AudioSource pickupFX;
    public GameObject pickUpDisplay;
    public GameObject weaponPanel;

    void OnTriggerEnter()
    {
        pickupFX.Play();
        transform.parent.gameObject.SetActive(false);
        realGun.SetActive(true);
        weaponPanel.SetActive(true);

        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<Text>().text = "HANDGUN";
        pickUpDisplay.SetActive(true);
    }
}
