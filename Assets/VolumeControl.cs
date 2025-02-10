using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public Slider volumeSlider;

    void Start()
    {
        // Define o volume salvo anteriormente ou usa 100% como padrão
        volumeSlider.value = PlayerPrefs.GetFloat("GameVolume", 1f);
        AudioListener.volume = volumeSlider.value;

        // Adiciona um evento para detectar mudanças no slider
        volumeSlider.onValueChanged.AddListener(ChangeVolume);
    }

    public void ChangeVolume(float volume)
    {
        AudioListener.volume = volume;

        // Salva o volume para futuras execuções
        PlayerPrefs.SetFloat("GameVolume", volume);
        PlayerPrefs.Save();
    }
}
