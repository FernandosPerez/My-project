using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JohnMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 control;

    public float speed;
    public Joystick joy;
    private float fuerza =3;

    private bool piso;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

       
            Vector2 mover = new Vector2(joy.Horizontal, joy.Vertical);
            control = mover.normalized * speed;
    }

    private void FixedUpdate()
    {

        rb.MovePosition(rb.position + (control * 2));

     

        

        if (transform.position.y <= -5 )
        {
            SceneManager.LoadScene("perder");
        }
        if (transform.position.x >= 100 )
        {
            SceneManager.LoadScene("ganar");
        }
       
        
    }


    public void brincar()
    {
        Vector2 mover = new Vector2(joy.Horizontal, joy.Vertical);
        control = mover.normalized * speed;
        mover.AddForce(mover.up * fuerza, ForceMode2D.Impulse);
    }



}

