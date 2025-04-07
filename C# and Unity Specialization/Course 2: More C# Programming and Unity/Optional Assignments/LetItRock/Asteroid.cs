using UnityEngine;

public class Asteroid : MonoBehaviour
{

    [SerializeField]
    int startSpeed = 10;

    [SerializeField]
    Sprite magentaSprite;
    [SerializeField]
    Sprite greenSprite;
    [SerializeField]
    Sprite whiteSprite;


    Rigidbody2D rb;
    float colliderRadius;

    SpriteRenderer spriteRend;

    void Awake()
    {
        ChooseRandomSprite();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (rb == null )
        {
            rb = gameObject.AddComponent<Rigidbody2D>();
        }

        CircleCollider2D col = GetComponent<CircleCollider2D>();

        if (col == null )
        {
            col = gameObject.AddComponent<CircleCollider2D>();
        }

        colliderRadius = col.radius;

        Vector2 thrustDirection = new Vector2(Random.Range(0f, 1f), Random.Range(0f, 1f)).normalized;

        rb.AddForce(thrustDirection * startSpeed, ForceMode2D.Impulse);

    }

    void OnBecameInvisible()
    {
        Vector2 position = transform.position;

        // check left, right, top, and bottom sides
        if (position.x + colliderRadius < ScreenUtils.ScreenLeft ||
            position.x - colliderRadius > ScreenUtils.ScreenRight)
        {
            position.x *= -1;
        }
        if (position.y - colliderRadius > ScreenUtils.ScreenTop ||
            position.y + colliderRadius < ScreenUtils.ScreenBottom)
        {
            position.y *= -1;
        }

        // move asteroid
        transform.position = position;
    }

    void ChooseRandomSprite()
    {
        spriteRend = GetComponent<SpriteRenderer>();

        int choice = Random.Range(0, 3);

        Debug.Log (choice);

        switch (choice)
        {
            case 0:
                spriteRend.sprite = magentaSprite; break;
            case 1:
                spriteRend.sprite = greenSprite; break;
            case 2:
                spriteRend.sprite = whiteSprite; break;
        }
    }

}
