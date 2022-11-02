using UnityEngine;
using UnityEngine.UI;

public class LevelCompleteStats : MonoBehaviour
{
    public static int numTreasure;
    public static int numEnemies;
    public static int finalScore;
    public static int timeCount;

    public GameObject treasureDisplay;
    public GameObject enemyDisplay;
    public GameObject scoreDisplay;
    public GameObject timeDisplay;
    
    void Update()
    {
        finalScore = GlobalScore.scoreValue;
        treasureDisplay.GetComponent<Text>().text = numTreasure.ToString();
        enemyDisplay.GetComponent<Text>().text = numEnemies.ToString();
        scoreDisplay.GetComponent<Text>().text = finalScore.ToString();
    }
}
