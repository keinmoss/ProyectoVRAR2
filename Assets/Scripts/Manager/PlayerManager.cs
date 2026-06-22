using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    void Start()
    {
        // 5 llamadas a variables del Singleton
        Debug.Log(GameStatsManager.Instance.counter);
        Debug.Log(GameStatsManager.Instance.health);
        Debug.Log(GameStatsManager.Instance.lives);
        Debug.Log(GameStatsManager.Instance.playerName);
        Debug.Log(GameStatsManager.Instance.score);

        // 5 llamadas a métodos del Singleton
        GameStatsManager.Instance.AddCounter();
        GameStatsManager.Instance.AddScore();
        GameStatsManager.Instance.HealPlayer();
        GameStatsManager.Instance.PrintName();
        GameStatsManager.Instance.ResetCounter();

        // 5 llamadas a métodos con argumentos
        GameStatsManager.Instance.AddNumbers(2, 3);
        GameStatsManager.Instance.MultiplyNumbers(4, 5);
        GameStatsManager.Instance.CreateMessage("Puntos: ", 10);
        GameStatsManager.Instance.GetHealth(20);
        GameStatsManager.Instance.GetLives(1);

        // 5 llamadas a métodos con argumentos y retorno
        int total = GameStatsManager.Instance.AddNumbers(5, 5);
        int mult = GameStatsManager.Instance.MultiplyNumbers(2, 4);
        string msg = GameStatsManager.Instance.CreateMessage("Nivel ", 1);
        int hp = GameStatsManager.Instance.GetHealth(10);
        string player = GameStatsManager.Instance.GetPlayerName("Jugador: ");

        Debug.Log(total);
        Debug.Log(mult);
        Debug.Log(msg);
        Debug.Log(hp);
        Debug.Log(player);
    }
}