using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public Texture2D[] textures;
    //private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.mainTexture = textures[0];
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 2, 1));

        // count++;
        // if (count == 50)
        // {
        //     GetComponent<Renderer>().material.mainTexture = textures[1];
        // }
        // else if (count == 100)
        // {
        //     count = 0;
        //     GetComponent<Renderer>().material.mainTexture = textures[0];
        // }
    }

    public void ChangeImage(int val) // Max 1 param in order to use it in Unity
    {
        GetComponent<Renderer>().material.mainTexture = textures[val];
    }
}
