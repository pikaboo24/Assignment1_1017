using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private float MoveSpeed = 7f;
    public Vector2 MinBounds;
    public Vector2 MaxBounds;
    [Header("Animation")]
    public Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");

        Vector3 newPosition = transform.position + new Vector3(HorizontalInput, VerticalInput).normalized * Time.deltaTime * MoveSpeed;
        newPosition.x = Mathf.Clamp(newPosition.x, MinBounds.x, MaxBounds.x);
        newPosition.y = Mathf.Clamp(newPosition.y, MinBounds.y, MaxBounds.y);
        transform.position = newPosition;
        if (HorizontalInput > 0)
        {
            animator.Play("Forward");
        } else if (HorizontalInput < 0)
        {
            animator.Play("Backward");
        }
        else
        { 

            if (VerticalInput > 0)
            {
                animator.Play("Strafe_left");
            }
            else if (VerticalInput < 0)
            {
                animator.Play("Strafe_right");


            }
            else
            {
                animator.Play("state-Idle");
            }
        }
    }

    
}
