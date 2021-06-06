using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        // Debug.Log("1+8×4は" + (1 + 8 * 4));
        // int x = 108;
        // Debug.Log(x);
        Person p = new Person();
        // p.name = "太郎";
        // p.show();
        p.firstname = "太郎";
        p.lastname = "山田";
        Debug.Log(p.GetFullName("★"));
    }

}

class Person {
    // public string name;

    // public void show(){
    // Debug.Log("私の名前は" + this.name);
    // }

    public string firstname;
    public string lastname;

    public string GetFullName (string separator){
        return this.lastname + separator +this.firstname;
    }

    public Person (string fn, string ln){
        this.firstname = fn;
        this.lastname = ln;
    }

    public Person(){}
}