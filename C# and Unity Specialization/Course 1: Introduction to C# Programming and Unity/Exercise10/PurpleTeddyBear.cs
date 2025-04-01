using UnityEngine;

public class PurpleTeddyBear : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Problem 3: Make the bear 4 times wider
        Vector3 newScale = transform.localScale;
        newScale.x *= 4;
        transform.localScale = newScale;
    }


}
