using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour{

    // Update is called once per frame
    void Update(){
        this.transform.Rotate(new Vector3(0, 0, 80) * Time.deltaTime);
    }
}