using System;
using System.Collections;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float _speed;
    private bool _moving;
    private Vector2 _input;
    [NonSerialized] 
    public bool Running;
    public Rigidbody2D body;
    public Animator animator;
    
    public Movement(bool running)
    {
        Running = running;
    }

    private void Start()
    {
        _speed = Running ? 10 : 5;
    }

    private void FixedUpdate()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");
        body.velocity = new Vector2(xMove* _speed, yMove * _speed);
        if (xMove > 0 && yMove == 0)
        {
            animator.SetInteger("Direction", 1);
        }
        else if (xMove < 0 && yMove == 0)
        {
            animator.SetInteger("Direction", 2);
        }
        else if (yMove > 0 && xMove == 0)
        {
            animator.SetInteger("Direction", 3);
        }
        else if (yMove < 0 && xMove == 0)
        {
            animator.SetInteger("Direction", 4);
        }
        else if (xMove > 0 && yMove > 0)
        {
            animator.SetInteger("Direction", 5);
        }
        else if (xMove < 0 && yMove > 0)
        {
            animator.SetInteger("Direction", 6);
        }
        else if (xMove > 0 && yMove < 0)
        {
            animator.SetInteger("Direction", 7);
        }
        else if (xMove < 0 && yMove < 0)
        {
            animator.SetInteger("Direction", 8);
        }
        else
        {
            animator.SetInteger("Direction", 0);
        }
        
        /*if (!_moving)
        {
            _input.x = Input.GetAxisRaw("Horizontal");
            _input.y = Input.GetAxisRaw("Vertical");

            if (_input != Vector2.zero)
            {
                var targetPosition = transform.position;
                targetPosition.x += _input.x;
                targetPosition.y += _input.y;
                body.velocity = new Vector2(_input.x * _speed, _input.y * _speed);
                //StartCoroutine(Move(targetPosition));
            }
        }*/
    }

    /*private IEnumerator Move(Vector3 targetPosition)
    {
        _moving = true;
        while ((targetPosition - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, _speed * Time.deltaTime);
            yield return null;
        }

        transform.position = targetPosition;

        _moving = false;
    }*/
}
