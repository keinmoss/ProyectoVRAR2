using UnityEngine;

public class EventListener : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.OnCounterEvent += CounterListener1;
        EventManager.OnCounterEvent += CounterListener2;
        EventManager.OnCounterEvent += CounterListener3;

        EventManager.OnHealthEvent += HealthListener1;
        EventManager.OnHealthEvent += HealthListener2;
        EventManager.OnHealthEvent += HealthListener3;

        EventManager.OnLivesEvent += LivesListener1;
        EventManager.OnLivesEvent += LivesListener2;
        EventManager.OnLivesEvent += LivesListener3;
    }

    private void OnDisable()
    {
        EventManager.OnCounterEvent -= CounterListener1;
        EventManager.OnCounterEvent -= CounterListener2;
        EventManager.OnCounterEvent -= CounterListener3;

        EventManager.OnHealthEvent -= HealthListener1;
        EventManager.OnHealthEvent -= HealthListener2;
        EventManager.OnHealthEvent -= HealthListener3;

        EventManager.OnLivesEvent -= LivesListener1;
        EventManager.OnLivesEvent -= LivesListener2;
        EventManager.OnLivesEvent -= LivesListener3;
    }

    void CounterListener1() { Debug.Log("Counter 1"); }
    void CounterListener2() { Debug.Log("Counter 2"); }
    void CounterListener3() { Debug.Log("Counter 3"); }

    void HealthListener1() { Debug.Log("Health 1"); }
    void HealthListener2() { Debug.Log("Health 2"); }
    void HealthListener3() { Debug.Log("Health 3"); }

    void LivesListener1() { Debug.Log("Lives 1"); }
    void LivesListener2() { Debug.Log("Lives 2"); }
    void LivesListener3() { Debug.Log("Lives 3"); }
}