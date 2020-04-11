using UnityEngine;


public class Airborne : MovementState
{
    private float timeElapsed;

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
    }

    public override void Move()
    {
        // Slightly influence falling path
    }

    public override void Dash()
    {
        // rigidbody.AddForce()
        // Transition to Dashing state
    }
}
