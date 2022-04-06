using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killing_Frogger : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // HERE WE KILL FROGGY
    // GOT HELP FROM CLASSMATES AND THE PROFESSOR ESPECIALLY
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Car")
        {
            Destroy(gameObject);
        }

    }
}
