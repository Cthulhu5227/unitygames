using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTest : MonoBehaviour
{
    public Animator anim;

    private Dictionary<KeyCode, string> keyToAnimationMap = new Dictionary<KeyCode, string>
    {
        { KeyCode.Alpha0, "Idle" },
        { KeyCode.Alpha1, "Walk" },
        { KeyCode.Alpha2, "Fly" },
        { KeyCode.Alpha3, "Dead_Ground" },
        { KeyCode.Alpha4, "Dead_Fly" },
        { KeyCode.Alpha5, "Atk_Claw_L" },
        { KeyCode.Alpha6, "Atk_Claw_R" },
        { KeyCode.Alpha7, "Claw_Double" },
        { KeyCode.Alpha8, "Breath_G_Straight" },
        { KeyCode.Alpha9, "Breath_F_Wide" }
    };

    void Start()
    {
        // Automatically assign the Animator component at start
        if (anim == null)
        {
            anim = GetComponent<Animator>();
            if (anim == null)
            {
                Debug.LogError("Animator component not found on the GameObject.");
            }
        }
    }

    void Update()
    {
        // Check each key in the map
        foreach (var pair in keyToAnimationMap)
        {
            if (Input.GetKeyDown(pair.Key))
            {
                // Play the animation corresponding to the key pressed
                if (anim != null)
                {
                    anim.Play(pair.Value, 0, 0f);
                }
            }
        }
    }
}
