using UnityEngine.UI;
using UnityEngine;

public class GoldCollect : MonoBehaviour
{
    public AudioSource pickupFX;
    public GameObject pickUpDisplay;

    void OnTriggerEnter()
    {
        GlobalScore.scoreValue += 500;
        pickupFX.Play();
        transform.parent.gameObject.SetActive(false);
        LevelCompleteStats.numTreasure += 1;
        
        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<Text>().text = "GOLD INGOTS";
        pickUpDisplay.SetActive(true);
    }
}
