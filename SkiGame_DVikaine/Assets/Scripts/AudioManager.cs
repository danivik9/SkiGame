using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip collisionSound;
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
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
