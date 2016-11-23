using UnityEngine;
using System.Collections;

public class BoomWait : BoomFunction {

    public static new BoomClassUID RTTI = new BoomClassUID("BoomWait", new BoomWait());

    public override BoomClassUID GetRTTI()
    {
        return BoomWait.RTTI;
    }

    public BoomWait()
    {

    }

    public override BoomObject CreateInstance()
    {
        return new BoomWait();
    }
}
