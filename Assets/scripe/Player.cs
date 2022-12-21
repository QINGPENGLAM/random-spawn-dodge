using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float speed = 15f;
    public float mapwidth = 5f;

    private Rigidbody2D rb;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        Vector2 newposition = rb.position + Vector2.right * x;

        newposition.x = Mathf.Clamp(newposition.x, -mapwidth, mapwidth); 

        rb.MovePosition(newposition);

    }

    private void OnCollisionEnter2D()
    {
        FindObjectOfType<gamemanager>().Endgame();
    }
}
