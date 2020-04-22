using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Dalamud.Game.ClientState.Actors;

namespace Dalamud.Game.ClientState.Structs
{
    /// <summary>
    /// Native memory representation of a FFXIV actor.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct Actor {
        [FieldOffset(0x30)] [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30)] public string Name;
        [FieldOffset(116)] public int ActorId;
        [FieldOffset(128)] public int DataId;
        [FieldOffset(132)] public int OwnerId;
        [FieldOffset(140)] public ObjectKind ObjectKind;
        [FieldOffset(141)] public byte SubKind;
        [FieldOffset(142)] public bool IsFriendly;
        [FieldOffset(144)] public byte YalmDistanceFromPlayer1; // Demo says one of these is x distance
        [FieldOffset(145)] public byte PlayerTargetStatus; // This is some kind of enum
        [FieldOffset(146)] public byte YalmDistanceFromPlayer2; // and the other is z distance
        [FieldOffset(160)] public Position3 Position;
        [FieldOffset(0x17F8)] public int TargetActorId;
        // This field can't be correctly aligned, so we have to cut it manually.
        [FieldOffset(0x17d0)] [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)] public byte[] CompanyTag;
        [FieldOffset(0x1868)] public int NameId;
        [FieldOffset(0x1884)] public byte CurrentWorld;
        [FieldOffset(0x1886)] public byte HomeWorld;
        [FieldOffset(6328)] public int CurrentHp;
        [FieldOffset(6332)] public int MaxHp;
        [FieldOffset(6336)] public int CurrentMp;
        [FieldOffset(6340)] public int MaxMp;
        [FieldOffset(6358)] public byte ClassJob;
        [FieldOffset(6360)] public byte Level;
        
    }
}
