using UnityEngine;

public class HandgunAmmoPickup : MonoBehaviour
{
    //public GameObject realGun;
    public AudioSource pickupFX;

    void OnTriggerEnter()
    {
        pickupFX.Play();
        gameObject.SetActive(false);
        GlobalAmmo.numAmmo += 10;
    }
}
