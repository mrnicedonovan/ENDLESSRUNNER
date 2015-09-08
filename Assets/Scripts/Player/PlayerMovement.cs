using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    //Animator animator;
    public float speed;
    public float jumpSpeed;
    private Rigidbody2D _Body;
 

    void Start()
    {
        //animator = GetComponent<Animator>();
        _Body = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
          //  animator.SetBool("trans1", true);
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(Vector2.right * speed * 2 * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.right * -speed * Time.deltaTime);
          //  animator.SetBool("trans1", true);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(Vector2.right * -speed * 2 * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
            //  animator.SetBool("trans1", true);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(Vector2.right * speed * 2 * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.up * -speed * Time.deltaTime);
            //  animator.SetBool("trans1", true);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(Vector2.right * -speed * 2 * Time.deltaTime);
            }
        }


    }


    void OnCollisionEnter2D(Collision2D Collider2D)
    {
            
        

        if (Collider2D.gameObject.CompareTag("Ground"))
        {
            
         //   isJumping = true;
            //animator.SetTrigger("Idle");
        }
    }
}