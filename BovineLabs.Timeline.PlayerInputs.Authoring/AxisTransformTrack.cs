using System;
using System.ComponentModel;
using BovineLabs.Reaction.Authoring.Core;
using BovineLabs.Timeline.Authoring;
using UnityEngine.Timeline;

namespace BovineLabs.Timeline.PlayerInputs.Authoring
{
    [Serializable]
    [TrackClipType(typeof(AxisTransformClip))]
    [TrackColor(0.2f, 0.9f, 0.4f)]
    [TrackBindingType(typeof(TargetsAuthoring))]
    [DisplayName("BovineLabs/Player Inputs/Axis Transform Track")]
    public sealed class AxisTransformTrack : DOTSTrack
    {
    }
}