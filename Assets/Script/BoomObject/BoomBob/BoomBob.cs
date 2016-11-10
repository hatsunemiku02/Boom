using UnityEngine;
using System.Collections;

public class BoomBob : BoomFunctionEntity {
    public static new BoomClassUID RTTI = new BoomClassUID("BoomBob");

    public override BoomClassUID GetRTTI()
    {
        return BoomBob.RTTI;
    }

}
