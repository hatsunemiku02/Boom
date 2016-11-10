using UnityEngine;
using System.Collections;

public class BoomAnimData : BoomData {
    public static new BoomClassUID RTTI = new BoomClassUID("BoomAnimData");

    public override BoomClassUID GetRTTI()
    {
        return BoomAnimData.RTTI;
    }

}
