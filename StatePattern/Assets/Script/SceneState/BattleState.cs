using UnityEngine;
using System.Collections;

public class BattleState :ISceneState {

   
	public BattleState(SceneStateContoller Controller) :base(Controller)
    {
        this.StateName = "BattleState";

    }

    public override void StateBegin()
    {
        Debug.Log("BattleStart");
    }
    public override void StateEnd()
    {
        Debug.Log("BattleEnd");
    }
    public override void StateUpdate()
    {
        //Debug.Log("Battle update!!");
    }
}
