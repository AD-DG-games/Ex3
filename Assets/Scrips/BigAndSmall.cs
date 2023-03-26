using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigAndSmall : MonoBehaviour
{
    // This variable controls the speed.
    // It can be adjusted in the Unity editor.
    [SerializeField]
    float speed = 1f;

    // This variable keeps track of the speed.
    float x = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(0.001f, 0.001f, 0.001f) * Mathf.Cos(x) * speed;
        x += 0.001f;
    }
}
