using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 配列は 宣言 初期化 代入 の流れ
        // int[] arr = { -1, 53, 21, 16, 4 };
        // for (int i = 0; i < 5; i++){
        //     arr[i] = arr[i] * 2;
        //     Debug.Log(arr[i]);}

        // クラス型配列変数
        // Person[] parr = new Person[5];
        // parr[0] = new Person();

        // Person[] parr = { new Person(), new Person() };

        Person[] parr = {
            new Person ("太郎", "山田"),
            new Person ("花子", "田中")
        };



        // parr[0].firstname = "太郎";
        // parr[0].lastname = "山田";
        Debug.Log(parr[0].GetFullName("★"));
        Debug.Log(parr[1].GetFullName("★"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
