using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    // Score Support
    int bounceCount = 0;
    string stringPrefix = "Bounces: ";

    [SerializeField]
    TextMeshProUGUI fullString;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        fullString.text = stringPrefix + bounceCount.ToString();
    }

    public void AddBounces()
    {
        bounceCount++;
        fullString.text = stringPrefix + bounceCount.ToString();
    }
}
