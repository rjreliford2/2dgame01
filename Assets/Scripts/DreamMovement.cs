using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class DreamMovement : MonoBehaviour
{
    public float speed;
    private float HorizInput;
    public Rigidbody2D body;
    public SpriteRenderer myRenderer;
    public Animator animator;
	public ParticleSystem fly;
    public GameObject flapNoisePrefab;
	
    void Update()
    {
        HorizInput = Input.GetAxis("Horizontal");
        if (HorizInput < 0)
        {
            myRenderer.flipX = true;
        }
        if (HorizInput > 0)
        {
            myRenderer.flipX = false;
        }
        if (Mathf.Abs(HorizInput) > 0f)
        {
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }

        if (Input.GetKeyDown("space"))
        {
            body.AddForce(transform.up * 10f, ForceMode2D.Impulse);
            animator.SetBool("Flap", true);
            Instantiate(flapNoisePrefab, this.transform.position, quaternion.identity);
            fly.Play();
        }
        if (Input.GetKeyUp("space"))
        {
            animator.SetBool("Flap", false);
			fly.Stop();
        }
        
    }

    void FixedUpdate() {
        body.velocity = new Vector2( HorizInput * speed, body.velocity.y );
        // body.MovePosition(new Vector2(body.position.x + HorizInput, body.position.y));
    }
}
