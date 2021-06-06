using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // int a = 7;
        // if(a<5){
        //     Debug.Log("aは５より小さい");
        // }else{
        //     Debug.Log("aは5以上");
        // }
        // Debug.Log("終了");
        int x = 0;
        while (x<8){
            x = Random.Range(0, 10);
            Debug.Log(x);
        }
        Debug.Log("終了");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
