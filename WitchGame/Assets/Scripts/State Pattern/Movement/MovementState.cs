public abstract class MovementState : State
{
    public static readonly MovementState Grounded = new Grounded();
    public static readonly MovementState Airborne = new Airborne();
    public static readonly MovementState Dashing = new Dashing();

    public virtual void Move() { }
    public virtual void Jump() { }
    public virtual void Dash() { }
}