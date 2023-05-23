package com.example.testunity;

import android.util.Log;

public class Test {

    public  static  String LOG= "log";
    public  String name;

    public  static  void SetLog(String log)
    {
        LOG = log;
        Log.d(LOG,"SetLog"+log);
    }

    public  static String GetLog()
    {

        Log.d(LOG,"GetLog"+LOG);
        return  LOG;
    }


    public    void SetName(String log)
    {
        this.name = log;
        Log.d(LOG,"SetLog"+log);
    }

    public   String GetName()
    {
        Log.d(LOG,"GetLog"+this.name);
        return  this.name ;
    }


}
