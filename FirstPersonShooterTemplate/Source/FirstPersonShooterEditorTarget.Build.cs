using Flax.Build;

public class FirstPersonShooterEditorTarget : GameProjectEditorTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for editor
        Modules.Add("FirstPersonShooter");
    }
}
