using UnityEngine;

public class Attacking : CombatState
{
    private float timeElapsed;
    private const float Duration = 0.5f;

    protected override void Enter()
    {
        timeElapsed = 0f;
        // SFX and particles
    }

    protected override void Exit()
    {
        // SFX and particles
    }

    public override void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= Duration)
        {
            // Transition to Idle state
        }
    }
}
