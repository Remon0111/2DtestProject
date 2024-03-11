using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// このScriptではBGMのSliderから現在の音量を取得してTextに表示させる処理を行っています。

public class BGMSlider : MonoBehaviour
{
    // Sliderの指定
    public Slider bgmSlider;

    // 表示させたいTextの指定
    public GameObject BGMVolume_object = null;

    Text BGMVolume_text;

    void Start()
    {
        BGMVolume_text = BGMVolume_object.GetComponent<Text>();

        int maxBGMVolume = 100;
        bgmSlider.maxValue = maxBGMVolume;

        int nowBGMVolume = PlayerPrefs.GetInt("BGMvolume", Mathf.RoundToInt(SettingsValues.BGMvol));
        bgmSlider.value = nowBGMVolume;
    }

    void Update()
    {
        int BGMVolume = Mathf.RoundToInt(bgmSlider.value);

        BGMVolume_text.text = BGMVolume.ToString();
    }
}
