using UnityEngine;

public class GreenTeddyBear : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Problem 2: Make the bear 4 times taller
        Vector3 newScale = transform.localScale;
        newScale.y *= 4;
        transform.localScale = newScale;
    }
}
