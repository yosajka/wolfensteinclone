using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public GameObject fadeOut;
    public GameObject completePanel;
    public GameObject thePlayer;
    public GameObject timer;

    public string nextLevel;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(CompletedFloor());
        StartCoroutine(SaveGame());
        thePlayer.GetComponent<FirstPersonMovement>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        timer.SetActive(false);
    }

    IEnumerator CompletedFloor()
    {
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        completePanel.SetActive(true);
        yield return new WaitForSeconds(15);
        GlobalScore.scoreValue = 0;
        LevelCompleteStats.numTreasure = 0;
        LevelCompleteStats.numEnemies = 0;

        if (nextLevel != null)
        {
            SceneManager.LoadScene(nextLevel);
        }
        
    }

    IEnumerator SaveGame()
    {
        PlayerPrefs.SetString("SceneToLoad", nextLevel);
        PlayerPrefs.SetInt("AmmoSaved", GlobalAmmo.numAmmo);
        PlayerPrefs.SetInt("LivesSaved", GlobalLife.lifeValue);

        if (nextLevel == "Credits")
        {
            PlayerPrefs.SetString("SceneToLoad", "Level01");
            PlayerPrefs.SetInt("AmmoSaved", 0);
            PlayerPrefs.SetInt("LivesSaved", 0);
        }
        
        Debug.Log(PlayerPrefs.GetString("SceneToLoad"));

        yield return null;
    }
}
