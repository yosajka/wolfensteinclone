using System.Collections;
using UnityEngine;

public class HandgunFire : MonoBehaviour
{
    //public GameObject theGun;
    public GameObject muzzleFlash;
    public AudioSource fireFx;
    public AudioSource emptyAmmmoFx;
    private bool isFiring;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (GlobalAmmo.numAmmo < 1)
            {
                emptyAmmmoFx.Play();
            }
            else
            {
                if (!isFiring)
                {
                    StartCoroutine(HandgunFiring());
                }
            }
        }
    }

    IEnumerator HandgunFiring()
    {
        isFiring = true;
        GlobalAmmo.numAmmo -= 1;
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
