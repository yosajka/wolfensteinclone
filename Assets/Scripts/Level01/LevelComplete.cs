using System.Collections;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public GameObject fadeOut;
    public GameObject completePanel;
    public GameObject thePlayer;
    public GameObject timer;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(CompletedFloor());
        thePlayer.GetComponent<FirstPersonMovement>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        timer.SetActive(false);
    }

    IEnumerator CompletedFloor()
    {
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        completePanel.SetActive(true);
    }
}
