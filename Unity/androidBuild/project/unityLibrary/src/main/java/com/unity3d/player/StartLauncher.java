package com.unity3d.player;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.widget.Button;

public class StartLauncher extends Activity  {

    // Setup activity layout
    @Override protected void onCreate(Bundle savedInstanceState)
    {

        super.onCreate(savedInstanceState);
    //使用 layout_activity 的layout显示
       setContentView(R.layout.layout_activity);
      Button btn= findViewById(R.id.button);
    //获取并添加按钮的响应
        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                //切换 StartLauncher  activity 场景 到 UnityPlayerActivity   activity 场景
                Intent intn= new Intent(StartLauncher.this,UnityPlayerActivity.class);
                startActivity(intn);
            }
        });
    }

}
