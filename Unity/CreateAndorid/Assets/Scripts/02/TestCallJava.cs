using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestCallJava : MonoBehaviour
{

    public InputField ifLog;
    public InputField ifName;

    public Button btnSetLog;
    public Button btnGetLog;
    public Button btnSetName;
    public Button btnGetName;

    public Text txtLog;
    public Text txtName;
    public Text txtYYY;
    // Start is called before the first frame update
    AndroidJavaClass classTest;
    AndroidJavaObject javaTest;
    void Start()
    {
#if UNITY_ANDROID

        //AndroidJavaClass    ��׿java �е���
        classTest = new AndroidJavaClass("com.example.testunity.Test");
        //AndroidJavaObject   ��׿ java�е������
        javaTest = new AndroidJavaObject("com.example.testunity.Test");
#endif

        btnSetLog.onClick.AddListener(() =>
        {
            SetLog();
        });
        btnSetName.onClick.AddListener(() =>
        {
            SetName();
        });

        btnGetName.onClick.AddListener(() =>
        {
            GetName();
        });
        btnGetLog.onClick.AddListener(() =>
        {
            GetLog();
        });

    }
    public void SetLog()
    {
        classTest.CallStatic("SetLog", ifLog.text);
    }
    public void GetLog()
    {
        txtLog.text = classTest.CallStatic<string>("GetLog");
    }
    public void SetName()
    {
        javaTest.Call("SetName", ifName.text);
    }
    public void GetName()
    {
        txtName.text = javaTest.Call<string>("GetName");
    }
    public void HHH(string tt)
    {
        txtYYY.text = tt;

    }

}
