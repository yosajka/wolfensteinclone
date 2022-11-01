using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public int enemyHealth = 20;
    public bool enemyDead = false;
    public GameObject enemyAI;
    public AudioSource deathSound;

    void DamageEnemy (int damageAmount)
    {
        enemyHealth -= damageAmount;
    }

    void Update()
    {
        if (enemyHealth <= 0 && enemyDead == false)
        {
            enemyDead = true;
            deathSound.Play();
            GlobalScore.scoreValue += 100;
            transform.parent.gameObject.GetComponent<Animator>().Play("death");
            transform.parent.gameObject.GetComponent<LookAtPlayer>().enabled = false;
            gameObject.GetComponent<MeshCollider>().enabled = false;
            enemyAI.SetActive(false);
            LevelCompleteStats.numEnemies += 1;
        }
    }
}