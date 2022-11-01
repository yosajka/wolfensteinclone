using UnityEngine;
using System.Collections;

public class SoldierAI : MonoBehaviour {

    public string hitTag;
    public bool lookingAtPlayer = false;
    public GameObject theSoldier;
    public GameObject muzzleFlash;
    public AudioSource fireFx;
    public float fireRate;
    bool isFiring = false;
    public AudioSource[] hurtSounds;
    int hurtIndex;
    public GameObject hurtFlash;

	void Update () {
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            hitTag = Hit.transform.tag;
        }
        if (hitTag == "Player" && !isFiring)
        {
            StartCoroutine(EnemyFire());
        }
        if (hitTag != "Player")
        {
            theSoldier.GetComponent<Animator>().Play("combat_idle");
            lookingAtPlayer = false;
        }

    }

    IEnumerator EnemyFire()
    {
        isFiring = true;
        theSoldier.GetComponent<Animator>().Play("combat_shoot", -1, 0);
        theSoldier.GetComponent<Animator>().Play("combat_shoot");
        fireFx.Play();
        muzzleFlash.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        muzzleFlash.SetActive(false);
        lookingAtPlayer = true;
        hurtFlash.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        hurtFlash.SetActive(false);
        GlobalHealth.healthValue -= 5;
        hurtIndex = Random.Range(0,3);
        hurtSounds[hurtIndex].Play();
        yield return new WaitForSeconds(fireRate);
        isFiring = false;
    }
}