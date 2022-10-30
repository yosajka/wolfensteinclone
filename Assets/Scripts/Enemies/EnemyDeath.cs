using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public int enemyHealth = 20;
    public bool enemyDead = false;
    public GameObject enemyAI;
    

    void DamageEnemy (int damageAmount)
    {
        enemyHealth -= damageAmount;
    }

    void Update()
    {
        if (enemyHealth <= 0 && enemyDead == false)
        {
            enemyDead = true;
            GetComponent<Animator>().Play("Death");
            enemyAI.SetActive(false);
        }
    }
}