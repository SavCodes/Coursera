using UnityEngine;

public class Mover : MonoBehaviour
{

    public Rigidbody2D rb;
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();

      Vector2 forceVector = new Vector2(0, 5);
      rb.AddForce(forceVector, ForceMode2D.Impulse);
    }

  
}
