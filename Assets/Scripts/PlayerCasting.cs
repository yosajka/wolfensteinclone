using UnityEngine;

public class PlayerCasting : MonoBehaviour
{
    public static float distanceFromTaget;
    public float distance;
    RaycastHit Hit;

    void Update()
    {
        
        if (Physics.Raycast(transform.position, transform.TransformVector(Vector3.forward), out Hit))
        {
            distanceFromTaget = Hit.distance;
            distance = distanceFromTaget;
        }
    }
}
