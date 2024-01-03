using Assets.Scripts;
using UnityEngine;
using UnityEngine.InputSystem;

public class ArrowKeysDetector : MonoBehaviour, IInputDetector
{
    private PlayerInput playerInput;

    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    /*    public InputDirection? DetectInputDirection()
        {
            if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W) || Input.GetMouseButtonUp(0))
                return InputDirection.Top;
            else if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
                return InputDirection.Bottom;
            else if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D))
                return InputDirection.Right;
            else if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A))
                return InputDirection.Left;
            else
                return null;
        }*/

    public InputDirection? DetectInputDirection()
    {

        if(playerInput.actions["Jump"].triggered)
        {
            return InputDirection.Top;
        }
        else if (playerInput.actions["MoveRight"].triggered)
        {
            return InputDirection.Right;
        }
        else if (playerInput.actions["MoveLeft"].triggered)
        {
            return InputDirection.Left;
        }
        return null;

    }
}