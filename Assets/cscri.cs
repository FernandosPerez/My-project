using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cscri : MonoBehaviour
{
    public GameObject john_idle_0;

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.x = john_idle_0.transform.position.x;
        transform.position = position;
    }
}
