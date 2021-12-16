using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_URL : MonoBehaviour
{
   public void GoPlay1()
    {
        Application.OpenURL("https://www.google.com/maps/place/%EA%B3%A0%EC%96%91%EC%9D%B4%EC%A0%95%EC%9B%90/@37.5756494,126.803077,15z/data=!4m5!3m4!1s0x0:0x5814bc065caa5818!8m2!3d37.5756494!4d126.803077");
    }

    public void GoPlay2()
    {
        Application.OpenURL("https://www.google.com/maps/place/%EB%B3%B4%EB%9D%BC%EB%A7%A4%EA%B3%B5%EC%9B%90/@37.4932343,126.9175228,17z/data=!3m1!4b1!4m5!3m4!1s0x357c9fbabf84aa17:0x64275ca1073cb20d!8m2!3d37.4932343!4d126.9197115");
    }

    public void GoPlay3()
    {
        Application.OpenURL("https://www.google.com/maps/place/%EC%A4%91%EC%95%99%EA%B3%B5%EC%9B%90/@37.3777863,127.1225442,17z/data=!4m5!3m4!1s0x357b581e52af665f:0x556bea7ec21c910!8m2!3d37.3777778!4d127.1247222");
    }

    public void GoPlay4()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=xEeFrLSkMm8");
    }

    public void GoQnA1()
    {
        Application.OpenURL("https://open.kakao.com/o/gsfKs3mb");
    }

    public void GoQnA2()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=EBOszmshKdY");
    }
    void Update()
    {
        ApplicationChrome.statusBarState = ApplicationChrome.States.Visible;
    }
}
