using UnityEngine;
using System.Collections;

public class BoomAnimData : BoomData {
    public static new BoomClassUID RTTI = new BoomClassUID("BoomAnimData",new BoomAnimData());

    public override BoomClassUID GetRTTI()
    {
        return BoomAnimData.RTTI;
    }

    public BoomAnimData()
    {

    }

    public override BoomObject CreateInstance()
    {
        return new BoomAnimData();
    }

}
