using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;

    public AudioClip backgournd;

    private void Start()
    {
        musicSource.clip = backgournd;
        musicSource.Play();
    }
}
