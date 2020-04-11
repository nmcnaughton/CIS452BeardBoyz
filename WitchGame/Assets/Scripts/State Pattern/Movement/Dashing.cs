using UnityEngine;

public class Dashing : MovementState
{
    private float timeElapsed;
    private const float Duration = 1.0f;

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
        if(timeElapsed >= Duration)
        {
            // Transition to Airborne state
        }
    }

    public override void Move()
    {
        // Slightly influence flight path ?
    }
}