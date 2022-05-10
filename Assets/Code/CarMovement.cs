using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{

    public float speed = 3.0f;

    void Update()

    {

        // Hint: In Unity You can get Vector (direction) shorthands like this:

        // Vector3.up

        // I searched the internet to help me out

        // Here is the Link:
        // https://answers.unity.com/questions/609527/how-do-i-make-a-game-object-move-in-the-direction.html



        float xDirection = Input.GetAxisRaw("Vertical");

        transform.position += transform.right * Time.deltaTime * speed;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);

        }

        if (collision.gameObject.tag == "Player")
        {

            Destroy(collision.gameObject);
        }
    }
}
       















