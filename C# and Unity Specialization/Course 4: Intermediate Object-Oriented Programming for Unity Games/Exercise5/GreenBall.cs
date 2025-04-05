using UnityEngine;

/// <summary>
/// Child of the Ball class
/// </summary>
public class GreenBall : Ball
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    override protected void Start()
    {
        this.impulseVector = new Vector2(0, 5);
        base.Start();
    }

    override protected void PrintMessage()
    {
        Debug.Log("I am a green ball");
    }
}
