using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Player : MonoBehaviour
{
    public float speed;
    public float input;
    public Rigidbody2D rb;
    public LayerMask wig;
    public Transform feetpos;
    private bool ig;
    public float cr;
    public float jf;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(input * speed, rb.velocity.y);

        ig = Physics2D.OverlapCircle(feetpos.position, cr, wig);

        if (ig == true && Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = Vector2.up * jf;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            rb.gravityScale = -1;
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            rb.gravityScale = 1;
        }

        if (input == 0)
        {
            anim.SetBool("Run", false);
        }
        else
        {
            anim.SetBool("Run", true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Respawn")
        {
            SceneManager.LoadScene("Tutorial");
        }
    }

 
}





