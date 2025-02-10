using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public Slider volumeSlider;

    void Start()
    {
        // Define o volume salvo anteriormente ou usa 100% como padr�o
        volumeSlider.value = PlayerPrefs.GetFloat("GameVolume", 1f);
        AudioListener.volume = volumeSlider.value;

        // Adiciona um evento para detectar mudan�as no slider
        volumeSlider.onValueChanged.AddListener(ChangeVolume);
    }

    public void ChangeVolume(float volume)
    {
        AudioListener.volume = volume;

        // Salva o volume para futuras execu��es
        PlayerPrefs.SetFloat("GameVolume", volume);
        PlayerPrefs.Save();
    }
}
