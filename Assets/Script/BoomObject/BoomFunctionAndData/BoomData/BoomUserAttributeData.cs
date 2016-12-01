using UnityEngine;
using System.Collections;

public class BoomUserAttributeData : BoomData
{
    public static new BoomClassUID RTTI = new BoomClassUID("BoomUserAttributeData",new BoomUserAttributeData());

    public override BoomClassUID GetRTTI()
    {
        return BoomUserAttributeData.RTTI;
    }

    public BoomUserAttributeData()
    {

    }

    public override BoomObject CreateInstance()
    {
        return new BoomUserAttributeData();
    }

}
