using BepInEx;
using RoR2;

namespace OmnidirectionalSprint
{
    [BepInDependency("com.bepis.r2api", BepInDependency.DependencyFlags.HardDependency)]
    [BepInPlugin("com.sladoinki.OmnidirectionalSprint", "OmnidirectionalSprint", "1.0.0")]
    public class OmnidirectionalSprint : BaseUnityPlugin
    {
        public void OnEnable()
        {
            RoR2.PlayerCharacterMasterController.onPlayerAdded += OnPlayerAdded;
        }
        private void OnPlayerAdded(RoR2.PlayerCharacterMasterController player)
        {
            player.master.onBodyStart += OnBodyStart;
        }

        private void OnBodyStart(RoR2.CharacterBody body)
        {
            body.bodyFlags |= RoR2.CharacterBody.BodyFlags.SprintAnyDirection;
        }
    }
}
