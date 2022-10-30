using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HandgunFire : MonoBehaviour
{
    public GameObject muzzleFlash;
    public AudioSource fireFx;
    public AudioSource emptyAmmmoFx;
    private bool isFiring;

    public float targetDistance;
    public int damageAmount;


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
        RaycastHit enemyHit;
        isFiring = true;
        GlobalAmmo.numAmmo -= 1;
        fireFx.Play();
        muzzleFlash.SetActive(true);
        GetComponent<Animator>().Play("Handgunfire");

        Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width/2, Screen.height/2));

        if (Physics.Raycast(ray.origin, ray.direction, out enemyHit))
        {
            //Debug.DrawRay(ray.origin, ray.direction * 40, Color.yellow, 40f);
            targetDistance = enemyHit.distance;
            enemyHit.transform.SendMessage("DamageEnemy", damageAmount, SendMessageOptions.DontRequireReceiver);
        }

        yield return new WaitForSeconds(0.05f);
        muzzleFlash.SetActive(false);
        yield return new WaitForSeconds(0.25f);
        GetComponent<Animator>().Play("New State");
        isFiring = false;
    }
}
