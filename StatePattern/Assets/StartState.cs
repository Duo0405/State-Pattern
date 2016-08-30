using UnityEngine;
using System.Collections;

public class StartState : ISceneState {

	public StartState(SceneStateContoller Controller) : base(Controller)
    {
        this.StateName = "StartState";
    }

    public override void StateBegin()
    {
        // loading... scene
    }

    public override void StateUpdate()
    {
        //m_Controller.
    }

}
