using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diamondScript : MonoBehaviour
{
    public SpriteRenderer rend;
    public Transform other;
    public Color newColor;

    [Range(-720, 720)]
    public float rotationSpeed; 
    // Use this for initialization
    void Start()
    {

        
        //other.localPosition = new Vector3(3, 8, other.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.2f, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-0.2f, 0, 0);
        }
    }
}
