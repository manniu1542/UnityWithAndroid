using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCallJava : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //AndroidJavaClass    ��׿java �е���
        AndroidJavaClass tmp = new AndroidJavaClass("com.example.testunity.Test");
        //AndroidJavaObject   ��׿ java�е������
        tmp.CallStatic("SetLog", "11111");
        var tt = tmp.CallStatic<string>("GetLog");
        Debug.LogError(tt);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
