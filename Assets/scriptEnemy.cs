using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptEnemy : MonoBehaviour
{

    public float limiteMovEnemy;
    float limiteMoveEnemy2;
    float limiteMoveEnemy3;

    // Start is called before the first frame update
    void Start()
    {
        limiteMoveEnemy2 = limiteMovEnemy + 1;
        limiteMoveEnemy3 = limiteMovEnemy + 2;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 enemyMovement = transform.position + new Vector3(0.5f, 0.5f, 0.0f) * limiteMovEnemy * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "shot")
        {
            Destroy(this.gameObject);
        }
        
    }
}
