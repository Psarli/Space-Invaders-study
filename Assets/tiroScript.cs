using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiroScript : MonoBehaviour
{
    public float speed;
    public float limite;
    


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        if(transform.position.y >= limite)
        {
            Destroy(gameObject);
        }        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "shield")
        {
            Destroy(this.gameObject);
        }
    }



}
