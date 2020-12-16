using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    protected Vector2 direction;
    [SerializeField]
    private float speed;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    protected virtual void Update()
    {
        Move();
    }
    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        if (this.direction.x != 0 || this.direction.y != 0)
        {
            animator.SetLayerWeight(1, 1);
            AnimateMove();
            Debug.Log(this.direction.x);
        }
        else
        {
            animator.SetLayerWeight(1, 0);
        }
    }
    public void AnimateMove()
    {
        animator.SetFloat("x", this.direction.x);
        animator.SetFloat("y", this.direction.y);
    }
}
