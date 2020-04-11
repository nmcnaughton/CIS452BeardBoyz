public abstract class CombatState : State
{
    public static readonly CombatState Idle = new Idle();
    public static readonly CombatState Attacking = new Attacking();

    public virtual void Attack() { }
}
