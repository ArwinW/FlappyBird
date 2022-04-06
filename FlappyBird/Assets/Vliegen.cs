using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vliegen : MonoBehaviour
{

    public float velocity = 1;
    //haalt de rigidbody op uit unity, deze voegt dingen zoals zwaarte kracht toe aan Flappy
    private Rigidbody2D rb;
    public float levens = 3;
    public GameObject pijp;

    // Start is called before the first frame update
    void Start()
    {     
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   //Functie als de spatieknop is ingedrukt
        if(Input.GetKey("space"))
        {
            //Zet de opwaartse kracht omhoog met de velocity die is aangegeven
            rb.velocity = Vector2.up * velocity;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        doodgaan();
    }

    void doodgaan()
    {
        levens -= 1;
        transform.position = new Vector2(-8, 1);
        Object.Destroy(pijp);
    }
}
