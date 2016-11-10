using UnityEngine;
using System.Collections;

public class BoomData : BoomObject {

    public static new BoomClassUID RTTI = new BoomClassUID("BoomData");

    public override BoomClassUID GetRTTI()
    {
        return BoomData.RTTI;
    }


}



