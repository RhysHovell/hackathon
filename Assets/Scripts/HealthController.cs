using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour {

    //Set up players initial health
    public const int maxHealth = 100;
    public float currentHealth = maxHealth;
    public HealthBar healthBar = new HealthBar();
    public float th; 

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        th = currentHealth / 100;
        healthBar.FillBar(th);
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            SceneManager.LoadScene("Game Over");
        }
    }

    

}
