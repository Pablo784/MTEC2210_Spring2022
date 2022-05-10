using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// I used these two websites for help
// Here are the two links
// 1. https://docs.unity3d.com/ScriptReference/Material.SetColor.html
// 2. https://answers.unity.com/questions/389027/how-do-you-change-the-color-of-an-obect-cube-cylin.html


public class Having_Color : MonoBehaviour

   
    
{
    
    




    // Start is called before the first frame update
    void Start()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        var cubeRenderer = cube.GetComponent<Renderer>();

        cubeRenderer.material.SetColor("_Color", Color.blue);
    }


   


    // Update is called once per frame
    void Update()

 

        // Changes Color

    {
        if (Input.GetKeyDown(KeyCode.A))
            GetComponent<Renderer>().material.color = Color.magenta;

        {

            if (Input.GetKeyDown(KeyCode.Space))
                GetComponent<Renderer>().material.color = Color.red;


            







        }


    }
}


