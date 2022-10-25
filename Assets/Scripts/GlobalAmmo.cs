using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour
{
    
    public static int numAmmo = 0;
    public GameObject ammoDisplay;

    // Update is called once per frame
    void Update()
    {
        ammoDisplay.GetComponent<Text>().text = numAmmo.ToString();
    }
}
