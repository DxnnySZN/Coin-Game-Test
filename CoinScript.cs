using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public float rotateSpeed;
    
    private void FixedUpdate(){
        transform.Rotate(Vector3.up, rotateSpeed);
        // this allows all the coins created to rotate at a speed set in the inspector tab
        // you must choose the coin that's under the prefabs folder and set the speed for that specific coin because that allows all the coins in the project to be affected by this code
    }
}
