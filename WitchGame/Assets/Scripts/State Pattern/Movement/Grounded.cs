public class Grounded : MovementState
{
    protected override void Enter()
    {
        // SFX and particles
    }

    protected override void Exit()
    {
        // SFX and particles
    }

    public override void Update()
    {
        // Nothing ?
    }

    public override void Move()
    {
        // rigidbody.MovePosition()
    }

    public override void Jump()
    {
        // rigidbody.AddForce()
        // Transition to Airborne state
    }

    public override void Dash()
    {
        // rigidbody.AddForce()
        // Transition to Dashing state
    }
}
