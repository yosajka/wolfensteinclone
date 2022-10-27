using UnityEngine;

public class SoldierAI : MonoBehaviour {

    public string hitTag;
    public bool lookingAtPlayer = false;
    public GameObject theSoldier;

	void Update () {
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            hitTag = Hit.transform.tag;
        }
        if (hitTag == "Player")
        {
            theSoldier.GetComponent<Animator>().Play("demo_combat_shoot");
            lookingAtPlayer = true;
        }
        else
        {
            theSoldier.GetComponent<Animator>().Play("demo_combat_idle");
            lookingAtPlayer = false;
        }

    }
}