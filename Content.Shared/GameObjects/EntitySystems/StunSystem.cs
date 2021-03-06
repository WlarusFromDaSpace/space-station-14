using Content.Shared.GameObjects.Components.Mobs;
using JetBrains.Annotations;
using Robust.Shared.GameObjects;

namespace Content.Shared.GameObjects.EntitySystems
{
    [UsedImplicitly]
    internal sealed class StunSystem : EntitySystem
    {
        public override void Update(float frameTime)
        {
            base.Update(frameTime);

            foreach (var component in ComponentManager.EntityQuery<SharedStunnableComponent>(true))
            {
                component.Update(frameTime);
            }
        }
    }
}
