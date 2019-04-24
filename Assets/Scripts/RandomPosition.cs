using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour{
    void Start(){
        transform.rotation = Random.rotation;
        transform.position = new Vector3(
            transform.position.x + Random.Range(-1f, 1f),
            transform.position.y + Random.Range(-1f, 1f),
            transform.position.z + Random.Range(-1f, 1f)
        );
    }
}
