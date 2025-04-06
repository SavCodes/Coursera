using UnityEngine;

/// <summary>
/// A zombie launcher
/// </summary>
public class ZombieLauncher : Launcher
{
    override protected void Start()
    {
        cooldownSeconds = 0.5f;

        base.Start();
    }
}
