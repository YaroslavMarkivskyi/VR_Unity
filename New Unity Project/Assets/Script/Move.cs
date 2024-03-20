using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello, Bitches");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(0f, 0.01f, 0f);
        transform.Translate(move);
    }
}
