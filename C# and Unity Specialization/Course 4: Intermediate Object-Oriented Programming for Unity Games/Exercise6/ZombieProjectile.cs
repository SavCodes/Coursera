using UnityEngine;

public class ZombieProjectile : Projectile
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    override protected void Start()
    {
        impulseForce.x = 3f;

        base.Start();
    }
    
}
