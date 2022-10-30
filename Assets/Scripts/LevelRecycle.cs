using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelRecycle : MonoBehaviour
{
    public GameObject gameOver;

    void Start()
    {
        GlobalLife.lifeValue -= 1;
        if (GlobalLife.lifeValue == 0)
        {
            gameOver.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene("Level01");
        }
    }

    
}
