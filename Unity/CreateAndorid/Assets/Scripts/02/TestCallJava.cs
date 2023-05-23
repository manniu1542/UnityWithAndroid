using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCallJava : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //AndroidJavaClass    安卓java 中的类
        AndroidJavaClass tmp = new AndroidJavaClass("com.example.testunity.Test");
        //AndroidJavaObject   安卓 java中的类对象
        tmp.CallStatic("SetLog", "11111");
        var tt = tmp.CallStatic<string>("GetLog");
        Debug.LogError(tt);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
