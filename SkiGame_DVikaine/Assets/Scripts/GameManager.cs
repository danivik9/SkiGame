using UnityEngine;

public class GameManager : MonoBehaviour
{
    public delegate void TimerEvent();
    private void OnEnable()
    {
        StartGate.StartRace += OnRaceStart;
    }
    void OnRaceStart()
    {
        Debug.Log("Race Started");
    }
}
