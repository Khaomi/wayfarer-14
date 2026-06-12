using Content.Shared.Actions;

namespace Content.Shared._HL.Sprite;

/// <summary>
/// Dedicated action event used exclusively by SpriteStateToggleComponent to avoid cross-talk with other Toggle systems.
/// </summary>
[Serializable]
public sealed partial class SpriteStateToggleActionEvent : InstantActionEvent
{
}
