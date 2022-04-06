using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pijp1 : MonoBehaviour
{
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Border")
        {
            transform.position = new Vector3(35, Random.Range(-height, height), 0);
        }
    }
}
