using UnityEngine;

public class L01Secret01 : MonoBehaviour
{
    public AudioSource slidingSound;
    
    void OnTriggerEnter()
    {
        transform.parent.gameObject.GetComponent<Animator>().enabled = true;
        GetComponent<BoxCollider>().enabled = false;
        slidingSound.Play();
    }
}
