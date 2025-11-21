using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationScript : MonoBehaviour
{
    public InputActionAsset xandersPlayerAction;
    public Animator xandersAnimator;

    // Update is called once per frame
    void Update()
    {
        if (xandersPlayerAction.FindAction("Move").IsPressed())
        {
            xandersAnimator.SetBool("Walk", true);
        }
        else
            xandersAnimator.SetBool("Walk", false);
    }
}