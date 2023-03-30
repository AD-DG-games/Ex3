using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearsAndDisappears : MonoBehaviour
{
    Vector3 realSize;
    bool isDisapeer = false;
    // Start is called before the first frame update
    void Start()
    {
        realSize = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isDisapeer)
            {
                transform.localScale = realSize;
                isDisapeer = false;
            }
            else
            {
                transform.localScale = new Vector3(0, 0, 0);
                isDisapeer = true;
            }
        }
    }
}
