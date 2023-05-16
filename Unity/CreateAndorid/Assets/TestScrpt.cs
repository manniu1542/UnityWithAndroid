using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScrpt : MonoBehaviour
{
    public Button btnLogin;
    public Button btnQuit;
    public Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        btnLogin.onClick.AddListener(() =>
        {
            ani.SetTrigger("Move");
        });

        btnQuit.onClick.AddListener(() =>
        {
            Application.Quit();
        });
    }

    // Update is called once per frame
    void Update()
    {

    }
}
