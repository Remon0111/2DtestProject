using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSettings : MonoBehaviour
{
    [SerializeField]
    Slider BGMVolumeSlider;

    [SerializeField]
    Slider SEVolumeSlider;

    [SerializeField]
    AudioMixer audioMixer;

    public void saveBGMsettings ()
    {
        SettingsValues.BGMvol = Mathf.RoundToInt(BGMVolumeSlider.value);
        PlayerPrefs.SetInt("BGMvolume", Mathf.RoundToInt(SettingsValues.BGMvol));

        Debug.Log(SettingsValues.BGMvol);
    }

    public void saveSEsettings ()
    {
        SettingsValues.SEvol = Mathf.RoundToInt(SEVolumeSlider.value);
        PlayerPrefs.SetInt("SEvolume", Mathf.RoundToInt(SettingsValues.SEvol));

        Debug.Log(SettingsValues.SEvol);
    }

    public void SetAudioMixerBGM ()
    {
        int AudioMixerBGMVolume = PlayerPrefs.GetInt("BGMvolume", Mathf.RoundToInt(SettingsValues.BGMvol));
        int volume = AudioMixerBGMVolume - 80;
        audioMixer.SetFloat("BGM", volume);
    }

    public void SetAudioMixerSE ()
    {
        int AudioMixerSEVolume = PlayerPrefs.GetInt("SEvolume", Mathf.RoundToInt(SettingsValues.SEvol));
        int volume = AudioMixerSEVolume - 80;
        audioMixer.SetFloat("SE", volume);
    }
}