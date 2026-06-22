using TMPro;
using UnityEngine;

public class GameStatsManager : MonoBehaviour
{
    // Singleton
    public static GameStatsManager Instance;

    // Variables
    public int counter = 0;
    public int health = 100;
    public int lives = 3;

    public string playerName = "Player";
    public float moveSpeed = 5f;
    public bool isAlive = true;
    public int score = 0;

    public TMP_Text counterText;
    public TMP_Text healthText;
    public TMP_Text livesText;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Métodos
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

    public void AddScore()
    {
        score += 10;
    }

    public void ResetCounter()
    {
        counter = 0;
        UpdateUI();
    }

    public void HealPlayer()
    {
        health += 10;
        UpdateUI();
    }

    public void ResetLives()
    {
        lives = 3;
        UpdateUI();
    }

    public void PrintName()
    {
        Debug.Log(playerName);
    }

    void UpdateUI()
    {
        counterText.text = "Counter: " + counter;
        healthText.text = "Health: " + health;
        livesText.text = "Lives: " + lives;
    }
    public int AddNumbers(int a, int b)
    {
        return a + b;
    }

    public int MultiplyNumbers(int a, int b)
    {
        return a * b;
    }

    public string CreateMessage(string name, int value)
    {
        return name + value;
    }
    public int GetHealth(int bonus)
    {
        return health + bonus;
    }

    public int GetLives(int extra)
    {
        return lives + extra;
    }

    public string GetPlayerName(string prefix)
    {
        return prefix + playerName;
    }
}