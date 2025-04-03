using UnityEngine;

public class BounceBorders : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Debugging Output
        Debug.Log(ScreenUtils.ScreenLeft);
        Debug.Log(ScreenUtils.ScreenRight);
        Debug.Log(ScreenUtils.ScreenTop);
        Debug.Log(ScreenUtils.ScreenBottom);

        // Create edge colliders
        EdgeCollider2D edgeOne = gameObject.AddComponent<EdgeCollider2D>();
        EdgeCollider2D edgeTwo = gameObject.AddComponent<EdgeCollider2D>();
        EdgeCollider2D edgeThree = gameObject.AddComponent<EdgeCollider2D>();
        EdgeCollider2D edgeFour = gameObject.AddComponent<EdgeCollider2D>();

        // Assign edge collider positions

        // Left wall Collider
        edgeOne.points = new Vector2[]

        {
            new Vector2(ScreenUtils.ScreenLeft, ScreenUtils.ScreenTop),
            new Vector2(ScreenUtils.ScreenLeft, ScreenUtils.ScreenBottom)
        };

        // Right wall Collider
        edgeTwo.points = new Vector2[]
        {
            new Vector2(ScreenUtils.ScreenRight, ScreenUtils.ScreenTop),
            new Vector2(ScreenUtils.ScreenRight, ScreenUtils.ScreenBottom)
        };

        // Bottom wall Collider
        edgeThree.points = new Vector2[]
        {
            new Vector2(ScreenUtils.ScreenLeft, ScreenUtils.ScreenBottom),
            new Vector2(ScreenUtils.ScreenRight, ScreenUtils.ScreenBottom)
        };


        // Top wall Collider
        edgeFour.points = new Vector2[]
        {
            new Vector2(ScreenUtils.ScreenLeft, ScreenUtils.ScreenTop),
            new Vector2(ScreenUtils.ScreenRight, ScreenUtils.ScreenTop)
        };

        // Assign Materials
        edgeOne.sharedMaterial = Resources.Load<PhysicsMaterial2D>("WallMaterial");
        edgeTwo.sharedMaterial = Resources.Load<PhysicsMaterial2D>("WallMaterial");
        edgeThree.sharedMaterial = Resources.Load<PhysicsMaterial2D>("WallMaterial");
        edgeFour.sharedMaterial = Resources.Load<PhysicsMaterial2D>("WallMaterial");

    }
}
