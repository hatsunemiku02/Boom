using UnityEngine;
using System.Collections;

public class BoomUserAttributeData : BoomData
{
    public static new BoomClassUID RTTI = new BoomClassUID("BoomUserAttributeData");

    public override BoomClassUID GetRTTI()
    {
        return BoomUserAttributeData.RTTI;
    }

}
