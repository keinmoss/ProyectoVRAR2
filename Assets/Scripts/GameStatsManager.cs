using TMPro;
using UnityEngine;

public class GameStatsManager : MonoBehaviour
{
    public int counter = 0;
    public int health = 100;
    public int lives = 3;

    public TMP_Text counterText;
    public TMP_Text healthText;
    public TMP_Text livesText;

    void Start()
    {
        UpdateUI();
    }

    public void AddCounter()
    {
        counter++;
        UpdateUI();
    }

    public void DamageHealth()
    {
        health -= 10;
        UpdateUI();
    }

    public void LoseLife()
    {
        lives--;
        UpdateUI();
    }

    void UpdateUI()
    {
        counterText.text = "Counter: " + counter;
        healthText.text = "Health: " + health;
        livesText.text = "Lives: " + lives;
    }
}