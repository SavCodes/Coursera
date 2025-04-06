using UnityEngine;

public class PirateProjectile : Projectile
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        impulseForce.x = 3f;

        base.Start();
    }

}
