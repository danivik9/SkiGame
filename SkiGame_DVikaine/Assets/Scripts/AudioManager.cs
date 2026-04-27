using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    [SerializeField] private AudioClip collisionSound;
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnEnable()
    {
        Obstacle.OnPlayerHit += PlayerCollisionSound;
    }
    private void PlayerCollisionSound()
    {
        audioSource.PlayOneShot(collisionSound);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
