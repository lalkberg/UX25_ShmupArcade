using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    private int currentHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // On spawn of either the player or the enemy, we set the currentHealth to be equal to the maximum health
        currentHealth = health;
    }

    public void Damage(int damage)
    {
        // first, we reduce our current health variable
        currentHealth -= damage;

        // then, if our health is equal to or less than 0, we die
        if (currentHealth <= 0)
        {
            Debug.Log("Enemy Killed!");
            // Destroy(gameObject) destroys the game object this component is located on!
            Destroy(gameObject);
        }
    }
}
