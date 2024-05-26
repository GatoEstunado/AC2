using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        // Movimento horizontal
        float horizontalInput = Input.GetAxis("Horizontal");
        // Movimento vertical
        float verticalInput = Input.GetAxis("Vertical");

        // Calcula a direção do movimento
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f) * moveSpeed * Time.deltaTime;

        // Move o jogador
        transform.Translate(movement);

        Moving();
    }

    private void Moving()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetFloat("Speed", -1f);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetFloat("Speed", 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetFloat("Speed", 1f);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetFloat("Speed", 0);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                anim.SetFloat("Speed", 1f);
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                anim.SetFloat("Speed", -1f);
            }
            else
            {
                anim.SetFloat("Speed", -1f);
            }
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetFloat("Speed", 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                anim.SetFloat("Speed", 1f);
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                anim.SetFloat("Speed", -1f);
            }
            else
            {
                anim.SetFloat("Speed", 1f);
            }
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetFloat("Speed", 0);
        }
    }
}

