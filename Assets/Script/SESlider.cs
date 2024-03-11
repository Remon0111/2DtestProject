using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SESlider : MonoBehaviour
{
    // Sliderの指定
    public Slider seSlider;

    //表示させたいTextの指定
    public GameObject SEVolume_object = null;

    Text SEVolume_text;

    void Start()
    {
        SEVolume_text = SEVolume_object.GetComponent<Text>();

        int maxSEVolume = 100;
        seSlider.maxValue = maxSEVolume;

        int nowSEVolume = PlayerPrefs.GetInt("SEvolume", Mathf.RoundToInt(SettingsValues.SEvol));
        seSlider.value = nowSEVolume;
    }

    // Update is called once per frame
    void Update()
    {
        int SEVolume = Mathf.RoundToInt(seSlider.value);

        SEVolume_text.text = SEVolume.ToString();
    }
}
