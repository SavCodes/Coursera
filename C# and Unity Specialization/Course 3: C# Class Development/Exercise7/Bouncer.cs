using UnityEngine;

public class Bouncer : MonoBehaviour
{
    int startForce = 100;

    // Initialize component requirements
    Rigidbody2D rb;
    Material material;

    // Bounce Support
    int health = 100;
    int bounceDamage = 10;

    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       rb.AddForce(new Vector2 (Random.Range(-startForce, startForce), Random.Range(-startForce, startForce)));
       material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject); 
        }
    }
    /// <summary>
    /// Decrements health and alpha on collision
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        health -= bounceDamage;  

        Color fadeColor = material.color;
        fadeColor.a = (float) health / 100;
        material.color = fadeColor;
    }
}
