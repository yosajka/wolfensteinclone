using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FloorTimer : MonoBehaviour
{
    public int secondCount;
    public int minuteCount;
    bool isAddingTime = false;
    public Text timeDisplay;

    
    void Update()
    {
        if (isAddingTime == false)
        {
            StartCoroutine(CountTime());
        }
        
    }

    IEnumerator CountTime()
    {
        isAddingTime = true;
        yield return new WaitForSeconds(1f);
        secondCount += 1;
        if (secondCount == 60)
        {
            secondCount = 0;
            minuteCount += 1;
        }

        if (secondCount < 9)
        {
            if (minuteCount < 9)
            {
                timeDisplay.text = "0" + minuteCount.ToString() + ":0" + secondCount.ToString();
            }
            else
            {
                timeDisplay.text = minuteCount.ToString() + ":0" + secondCount.ToString();
            }
        }
        else
        {
            if (minuteCount < 9)
            {
                timeDisplay.text = "0" + minuteCount.ToString() + ":" + secondCount.ToString();
            }
            else
            {
                timeDisplay.text = minuteCount.ToString() + ":" + secondCount.ToString();
            }
        }

        isAddingTime = false;
    }
}
