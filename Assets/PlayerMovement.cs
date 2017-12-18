using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject Player;
    public float speed;
    public Rigidbody2D rigid;
	public bool ground;

    // Use this for initialization
    void Start()
    {
        //Rigidbody2D rigid = Player.GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
		ground = true;
        //print("Colliding");
    }

    // Update is called once per frame
    void Update()
    {
        float move = speed * Time.deltaTime;
        if (Input.GetKey("d"))
        {
            transform.Translate(move, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(-1 * move, 0, 0);
        }
        if (Input.GetKey("space") && ground)
        {

            rigid.AddForce(Vector2.up * 400);
			ground = false;
			//print ("Jump turned to false");
            
        }
    }
}
