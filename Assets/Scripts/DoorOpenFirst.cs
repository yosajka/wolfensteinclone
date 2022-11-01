using UnityEngine;
using System.Collections;

public class DoorOpenFirst : MonoBehaviour
{
    public AudioSource doorFX;

    void OnTriggerEnter()
    {
        doorFX.Play();
        transform.parent.gameObject.GetComponent<Animator>().Play("DoorOpen");
        GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(DoorClose());
    }

    IEnumerator DoorClose()
    {
        yield return new WaitForSeconds(5f);
        doorFX.Play();
        transform.parent.gameObject.GetComponent<Animator>().Play("DoorClose");
        GetComponent<BoxCollider>().enabled = true;
    }
}
