using UnityEngine;
public class StartGate : MonoBehaviour
{
    public static event GameManager.TimerEvent StartRace;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            StartRace.Invoke();
        }
    }
}
