using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoomGame : BoomObject {

    public static new BoomClassUID RTTI = new BoomClassUID("BoomGame", new BoomGame());

    public override BoomClassUID GetRTTI()
    {
        return BoomGame.RTTI;
    }

    public BoomGame()
    {

    }

    public override BoomObject CreateInstance()
    {
        return new BoomGame();
    }

    private BoomScene m_GameScene;
    private List<BoomDude> m_DudeArray;
    private List<BoomBob> m_BoomArray;

}
