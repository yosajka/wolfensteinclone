using UnityEngine;

public class GunPickup : MonoBehaviour
{
    public GameObject realGun;
    public AudioSource pickupFX;

    void OnTriggerEnter()
    {
        pickupFX.Play();
        transform.parent.gameObject.SetActive(false);
        realGun.SetActive(true);
    }
}
