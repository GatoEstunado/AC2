using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    public float speed = 5f;
    public Sprite idleSprite;
    public Sprite moveLeftSprite;
    public Sprite moveRightSprite;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Captura a entrada do jogador
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        // Muda o sprite com base no estado de movimento
        if (movement.x > 0)
        {
            spriteRenderer.sprite = moveRightSprite;
        }
        else if (movement.x < 0)
        {
            spriteRenderer.sprite = moveLeftSprite;
        }
        else
        {
            spriteRenderer.sprite = idleSprite;
        }
    }

    void FixedUpdate()
    {
        // Move o personagem
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
