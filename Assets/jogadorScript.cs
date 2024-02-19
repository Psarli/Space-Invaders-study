using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogadorScript : MonoBehaviour
{

    int speed = 6;
    public GameObject projetil;




    void Start()
    {
        Vector3 posicaoInicial = transform.position + new Vector3(0f, -3.18f, 0f);
    }

    
    void Update()
    {
        //input para o movimento do personagem
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        

        transform.Translate(moveX, 0.0f, 0.0f); // move o personagem baseado no input


        if (Input.GetButtonDown("Jump"))
        {
            Vector3 spawntiro = transform.position + new Vector3(0.0f, 1f, 0.0f);
            Instantiate(projetil, spawntiro, transform.rotation);
        }
    }



    //Transportador nos cantos da tela
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "tpin")
        {
            transform.position =  new Vector2(8.32f, -3.76f);
        }
        if (collision.gameObject.tag == "tpout")
        {
            transform.position = new Vector2(-8.32f, -3.76f);
        }
    }

}
