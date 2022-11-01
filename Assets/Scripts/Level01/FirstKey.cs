using UnityEngine;

public class FirstKey : MonoBehaviour
{
    public GameObject keyUI;
    public GameObject lockedTrigger;
    public AudioSource keyCollectFx;
    

    void OnTriggerEnter(Collider other)
    {
        keyCollectFx.Play();
        keyUI.SetActive(true);
        lockedTrigger.SetActive(true);
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        transform.parent.gameObject.SetActive(false);
    }
}
