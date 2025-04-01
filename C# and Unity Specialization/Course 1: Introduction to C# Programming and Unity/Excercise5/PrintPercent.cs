using UnityEngine;

public class PrintPercent : MonoBehaviour
{
   void Start()
    {
        const int MaxScore = 100;
        int score = 95;
        float percent = (float) score / MaxScore * 100;
        Debug.Log(percent);
    }
}
