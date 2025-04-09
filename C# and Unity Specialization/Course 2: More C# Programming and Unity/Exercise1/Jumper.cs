using UnityEngine;

public class Jumper : MonoBehaviour
{
    // Jump location support
    const float minX = 0;
    const float maxX = 3;
    const float minY = 0;
    const float maxY = 3;

    // Timer Support
    const float TotalJumpDelaySeconds = 1;
    float elapsedJumpDelaySeconds = 0;



    // Update is called once per frame
    void Update()
    {
        //U Update the jump timer
        elapsedJumpDelaySeconds += Time.deltaTime;

        if (elapsedJumpDelaySeconds >= TotalJumpDelaySeconds)
        {
            elapsedJumpDelaySeconds = 0;
            Vector2 position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
            transform.position = position;
        }
    }
}
