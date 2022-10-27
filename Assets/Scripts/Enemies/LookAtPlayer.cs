using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");    
    }

    
    void Update()
    {
        transform.LookAt(player.transform);    
    }
}
