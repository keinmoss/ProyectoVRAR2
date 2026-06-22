using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static event Action OnCounterEvent;
    public static event Action OnHealthEvent;
    public static event Action OnLivesEvent;

    public void TriggerCounterEvent()
    {
        OnCounterEvent?.Invoke();
    }

    public void TriggerHealthEvent()
    {
        OnHealthEvent?.Invoke();
    }

    public void TriggerLivesEvent()
    {
        OnLivesEvent?.Invoke();
    }
}