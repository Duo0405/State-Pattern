using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class MainMenuState : ISceneState {

	public  MainMenuState(SceneStateContoller Controller):base(Controller)
    {
        this.StateName = "MainMenuState";
    }

    public override void StateBegin()
    {
        Button tmpBtn = UITool.GetUIComponent<Button>("StartGameBtn");
        if (tmpBtn != null)
            tmpBtn.onClick.AddListener(() => StartGameBtnClick(tmpBtn));
        
    }
    
    private void StartGameBtnClick(Button startButton)
    {
        Debug.Log("OnStartClick:" + startButton.gameObject.name);
        m_Controller.SetState(new BattleState(m_Controller), "BattleScene");
    }
}
