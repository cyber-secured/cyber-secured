// SceneControllerTitle.cs

/// <summary>
/// This script controls the title screen; in tandem with GlitchCamera.cs
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// imported scripts
using DG.Tweening;

public class SceneControllerTitle : MonoBehaviour
{
    
    public GameObject background;               // background image

    public GameObject scn_title;                // title scene
    public Text txt_title;                      // --
    public Button btn_start;                    // --
    public Button btn_instruct;                 // --
    public Button btn_options;                  // --

    public GameObject scn_instruct;             // instructions scene
    public Button btn_return_instruct;          // --

    public GameObject scn_options;              // options menu
    public Button btn_return_options;           // --
    public Button btn_reset_game;               // --
    public Button btn_return_main;              // --

	// Use this for initialization
	void Start()
	{
        
	}
	
	// Update is called once per frame
	void Update()
	{
		
	}

    // button function to see instructions
    public void DisplayInstructions()
    {
        // play a beep sound
        GameObject.Find("SoundManager").GetComponent<AudioControllerV2>().PlaySound(1);

        // move to instructions area to the middle of the screen, and move title screen over
        scn_instruct.transform.DOLocalMove(new Vector3(0, 0, 0), 0.7f);
        scn_title.transform.DOLocalMove(new Vector3(1200, 0, 0), 0.7f);
        background.transform.DOLocalMove(new Vector3(1, 0 ,0), 0.7f);

        // disable title buttons
        SwitchTitleButtons();

        // change state to instructions
        GameControllerV2.Instance.SetState(1);
    }

    // button function to see options
    // TODO: make options functional
    public void DisplayOptions()
    {
        // play a beep sound
        GameObject.Find("SoundManager").GetComponent<AudioControllerV2>().PlaySound(1);

        // move to instructions area to the middle of the screen, and move title screen over
        scn_options.transform.DOLocalMove(new Vector3(0, 0, 0), 0.7f);
        scn_title.transform.DOLocalMove(new Vector3(-1200, 0, 0), 0.7f);
        background.transform.DOLocalMove(new Vector3(-1, 0 ,0), 0.7f);

        // disable title buttons
        SwitchTitleButtons();

        // change states to options
        //CURRENT_STATE = State.options;
        GameControllerV2.Instance.SetState(2);
    }

    // button function to move back to title screen
    public void MoveToTitle()
    {
        // play a beep sound
        GameObject.Find("SoundManager").GetComponent<AudioControllerV2>().PlaySound(1);

        // either in instruction scene or options scene
        if(GameControllerV2.Instance.GetState() == 1)
        {
            // move title and instructions back to place
            scn_instruct.transform.DOLocalMove(new Vector3(-1200, 0, 0), 0.7f);
            scn_title.transform.DOLocalMove(new Vector3(0, 0, 0), 0.7f);
            background.transform.DOLocalMove(new Vector3(0, 0 ,0), 0.7f);
        } else {
            // move title and options menu back to place
            scn_options.transform.DOLocalMove(new Vector3(1200, 0, 0), 0.7f);
            scn_title.transform.DOLocalMove(new Vector3(0, 0, 0), 0.7f);
            background.transform.DOLocalMove(new Vector3(0, 0 ,0), 0.7f);
        }

        // enable title buttons
        SwitchTitleButtons();

        // change state back to title
        //CURRENT_STATE = State.title;
        GameControllerV2.Instance.SetState(0);
    }

    // enables or disables title buttons
    public void SwitchTitleButtons()
    {
        // use start button to check all three buttons
        if(btn_start.interactable)
        {
            // disable title screen buttons
            btn_start.interactable = false;
            btn_instruct.interactable = false;
            btn_options.interactable = false;

            // enable the return buttons
            btn_return_instruct.interactable = true;
            btn_return_options.interactable = true;
        } else {
            // enable title screen buttons
            btn_start.interactable = true;
            btn_instruct.interactable = true;
            btn_options.interactable = true;

            // disable the return buttons
            btn_return_instruct.interactable = false;
            btn_return_options.interactable = false;
        }
    }

    // disables instructions scene
    public void DisableInstruct()
    {
        scn_instruct.gameObject.SetActive(false);
    }

    public void HideTitle()
    {
        // deactivate title objects; to main game state
        txt_title.gameObject.SetActive(false);
        btn_start.gameObject.SetActive(false);
        btn_instruct.gameObject.SetActive(false);
        btn_options.gameObject.SetActive(false);
    }
}
