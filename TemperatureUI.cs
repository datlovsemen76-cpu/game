using TMPro;

public class TemperatureUI : MonoBehaviour
{
    private PlayerTemperature playerTemperature;
    private TextMeshProUGUI temperatureText;

    void Update()
    {
        UpdateTemperatureDisplay();
    }

    private void UpdateTemperatureDisplay()
    {
        float roundedTemperature = Mathf.Round(playerTemperature.currentTemperature * 10.0f) * 0.1f;
        temperatureText.text = roundedTemperature.ToString();
    }
}
