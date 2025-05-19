using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;

public class BrightnessControl : MonoBehaviour
{
    public PostProcessVolume volume;
    public Slider slider;
    private AutoExposure exposure;

    void Start()
    {
        volume.profile.TryGetSettings(out exposure);
        slider.onValueChanged.AddListener(UpdateBrightness);
    }

    void UpdateBrightness(float value)
    {
        if (exposure != null)
        {
            exposure.keyValue.value = value;
        }
    }
}
