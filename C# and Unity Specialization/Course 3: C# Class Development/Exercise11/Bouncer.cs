using UnityEngine;

public class Bouncer : MonoBehaviour
{
    // Movement support
    const int MoveSpeed = 60;

    // Item assignment
    Renderer rend;
    Rigidbody2D rb;
    AudioSource audioSource;
    HUD hud;

    void Start()
    {
        // Get the HUD
        hud = GameObject.FindGameObjectWithTag("HUD").GetComponent<HUD>();

        // Get game object components
        rend = GetComponent<Renderer>();
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();


        if (rb == null )
        {
            rb = gameObject.AddComponent<Rigidbody2D>();
        }    

        rb.AddForce(new Vector2(Random.Range(-1, 1), Random.Range(-1, 1)).normalized * MoveSpeed * Time.deltaTime, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Fade the ball color
        Color fadeColor = rend.material.color;
        fadeColor.a -= 0.1f;
        rend.material.color = fadeColor;

        // Add bounces 
        hud.AddBounces();

        // Play sound
        audioSource.Play();
    }
}
