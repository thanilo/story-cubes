using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableTilt : MonoBehaviour{
    void Update(){
        if(Input.GetMouseButtonDown(1) || Input.GetMouseButtonUp(1)){
            FireTilt();
        }
    }
    void FixedUpdate(){
            transform.position = new Vector3(
            transform.position.x,
            transform.position.y - transform.position.y * Time.deltaTime * 2f,
            transform.position.z
        );
    }

    void FireTilt(){
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y + 1f,
            transform.position.z
        );
    }
}
