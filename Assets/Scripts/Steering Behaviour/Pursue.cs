using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pursue : MonoBehaviour 
{
    /*
    Rigidbody2D rb;

    Player target;  //< -------
	Vector2 targetPos;

    Vector2 direction;
    Vector2 velocity = new Vector2(1,0);
	
    Vector2 desired_velocity;
	Vector2 steering_velocity;

	public float speed = 5;
	public float mass = 20;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    private void Update()
	{
        targetPos = GetTargetFuturePosition();

        direction = (targetPos - (Vector2)transform.position).normalized;
        desired_velocity = direction * speed;

		steering_velocity = desired_velocity - velocity;
		steering_velocity = steering_velocity / mass;

		velocity += steering_velocity;
        
        Rotate();
	}

    private void FixedUpdate()
    {
        rb.velocity = velocity;
    }

    void Rotate()
    {
        float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, 0, angle);
    }

    Vector2 GetTargetFuturePosition()
	{
        if (target.velocity.magnitude > 0.5f)
        {
            float distance = Vector2.Distance(target.transform.position, transform.position);
            float T = distance / target.velocity.magnitude;

            return (Vector2)target.transform.position + (target.velocity * T);
        }
        else
            return target.transform.position;
	}

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.cyan;
		Gizmos.DrawWireSphere(targetPos, 0.5f);
	}
    */
    
}
