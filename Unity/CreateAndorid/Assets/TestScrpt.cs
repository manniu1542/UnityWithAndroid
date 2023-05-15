using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScrpt : MonoBehaviour
{
    public Button btnLogin;
    public Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        btnLogin.onClick.AddListener(() =>
        {
            ani.SetTrigger("Move");
        });


    }

    // Update is called once per frame
    void Update()
    {

    }
}
