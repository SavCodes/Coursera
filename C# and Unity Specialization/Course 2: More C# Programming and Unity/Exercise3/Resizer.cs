using UnityEngine;

public class Resizer : MonoBehaviour
{

    // Timer support 
    const float TotalResizeSeconds = 1;
    float elapsedResizeSeconds = 0;

    // Resizing Control
    const float ScaleFactorPerSecond = 1;
    int scaleFactorSignMultiplier = 1;


    // Update is called once per frame
    void Update()
    {
        // Shrinking and Growing
        Vector2 newScale = transform.localScale;
        newScale.x += ScaleFactorPerSecond * scaleFactorSignMultiplier * Time.deltaTime;
        newScale.y += ScaleFactorPerSecond * scaleFactorSignMultiplier * Time.deltaTime;
        transform.localScale = newScale;

        elapsedResizeSeconds += Time.deltaTime;
        if (elapsedResizeSeconds >= TotalResizeSeconds)
        {
            elapsedResizeSeconds = 0;
            scaleFactorSignMultiplier *= -1;
        }
    }
}
