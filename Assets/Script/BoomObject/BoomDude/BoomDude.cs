using UnityEngine;
using System.Collections;

public class BoomDude : BoomFunctionEntity {
    public static new BoomClassUID RTTI = new BoomClassUID("BoomDude");

    public override BoomClassUID GetRTTI()
    {
        return BoomDude.RTTI;
    }

}
