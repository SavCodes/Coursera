using UnityEngine;

/// <summary>
/// A pirate launcher
/// </summary>
public class PirateLauncher : Launcher
{
    override protected void Start()
    {
        cooldownSeconds = 1f;

        base.Start();
    }
}
