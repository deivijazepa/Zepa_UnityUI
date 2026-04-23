using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class UIButtonSound : MonoBehaviour
{
    public AudioClip clickSound;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayClickSound()
    {
        if (clickSound != null)
        {
            audioSource.PlayOneShot(clickSound);
        }
    }
}