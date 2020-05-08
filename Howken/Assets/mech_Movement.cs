using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mech_Movement : MonoBehaviour
{
    void Update()
    {
        this.transform.Translate(new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime, 0, Input.GetAxis("Vertical")*Time.deltaTime));
    }
}
