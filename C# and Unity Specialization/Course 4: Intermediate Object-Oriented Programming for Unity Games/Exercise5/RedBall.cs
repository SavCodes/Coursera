using UnityEngine;

public class RedBall : Ball
{
    override protected void PrintMessage()
    {
        Debug.Log("I am a red ball");
    }
}
