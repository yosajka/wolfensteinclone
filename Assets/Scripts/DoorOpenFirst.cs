using UnityEngine;
using System.Collections;

public class DoorOpenFirst : MonoBehaviour
{
    public AudioSource doorFX;

    void OnTriggerEnter()
    {
        doorFX.Play();
        transform.parent.gameObject.GetComponent<Animator>().Play("L1Door01");
        GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(DoorClose());
    }

    IEnumerator DoorClose()
    {
        yield return new WaitForSeconds(5f);
        doorFX.Play();
        transform.parent.gameObject.GetComponent<Animator>().Play("L1Door01Close");
        GetComponent<BoxCollider>().enabled = true;
    }
}
