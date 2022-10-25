using System.Collections;
using UnityEngine;

public class HandgunFire : MonoBehaviour
{
    //public GameObject theGun;
    public GameObject muzzleFlash;
    public AudioSource fireFx;
    private bool isFiring;


    void Update()
    {
        if (!isFiring)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                StartCoroutine(HandgunFiring());
            }
            
        }
    }

    IEnumerator HandgunFiring()
    {
        isFiring = true;
        fireFx.Play();
        muzzleFlash.SetActive(true);
        GetComponent<Animator>().Play("Handgunfire");
        yield return new WaitForSeconds(0.05f);
        muzzleFlash.SetActive(false);
        yield return new WaitForSeconds(0.25f);
        GetComponent<Animator>().Play("New State");
        isFiring = false;
    }
}
