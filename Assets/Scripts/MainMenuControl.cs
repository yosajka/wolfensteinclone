using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    public AudioSource clickSound;
    public GameObject fadeOut;
    public GameObject fadeIn;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        StartCoroutine(FadeIn());
    }


    public void NewGame()
    {
        StartCoroutine(NewGameRoutine());
    }

    IEnumerator NewGameRoutine()
    {
        clickSound.Play();
        fadeOut.SetActive(true);
        PlayerPrefs.SetString("SceneToLoad", "Level01");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Level01");
    }

    IEnumerator FadeIn()
    {
        fadeIn.SetActive(true);
        yield return new WaitForSeconds(1.1f);
        fadeIn.SetActive(false);
    }

    public void QuitGame()
    {
        clickSound.Play();
        Application.Quit();
    }

    public void Reset()
    {
        clickSound.Play();
        PlayerPrefs.SetString("SceneToLoad", "Level01");
        PlayerPrefs.SetInt("AmmoSaved", 0);
        PlayerPrefs.SetInt("LivesSaved", 0);
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadGame()
    {
        StartCoroutine(LoadGameRoutine());
    }

    IEnumerator LoadGameRoutine()
    {
        clickSound.Play();
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        GlobalAmmo.numAmmo = PlayerPrefs.GetInt("AmmoSaved");
        GlobalLife.lifeValue = PlayerPrefs.GetInt("LivesSaved");
        SceneManager.LoadScene(PlayerPrefs.GetString("SceneToLoad"));
    }

    public void LoadCredit()
    {
        clickSound.Play();
        SceneManager.LoadScene("Credits");
    }

}