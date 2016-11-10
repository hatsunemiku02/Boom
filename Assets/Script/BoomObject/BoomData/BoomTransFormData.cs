using UnityEngine;
using System.Collections;

public class BoomTransFormData : BoomData
{
    public static new BoomClassUID RTTI = new BoomClassUID("BoomTransFormData");

    public override BoomClassUID GetRTTI()
    {
        return BoomTransFormData.RTTI;
    }

}
