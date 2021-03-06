using ETModel;
namespace ETModel
{
	[Message(FrameOpcode.OneFrameMessage)]
	public partial class OneFrameMessage : IActorMessage {}

	[Message(FrameOpcode.FrameMessage)]
	public partial class FrameMessage : IActorMessage {}

	[Message(FrameOpcode.PeerInfo)]
	public partial class PeerInfo {}

	[Message(FrameOpcode.MoveInfo)]
	public partial class MoveInfo {}

	[Message(FrameOpcode.UnitSnatshot)]
	public partial class UnitSnatshot {}

	[Message(FrameOpcode.UnitSnapshotMsg)]
	public partial class UnitSnapshotMsg : IActorMessage {}

	[Message(FrameOpcode.ClientInitComplete)]
	public partial class ClientInitComplete : IActorMessage {}

	[Message(FrameOpcode.SnapShotMessage)]
	public partial class SnapShotMessage : IActorMessage {}

	[Message(FrameOpcode.LocalNCFAndJLE)]
	public partial class LocalNCFAndJLE : IActorMessage {}

//int32 CurrentHostId = 3;
	[Message(FrameOpcode.JoinEvent)]
	public partial class JoinEvent : IActorMessage {}

	[Message(FrameOpcode.JoinLeaveEventMessage)]
	public partial class JoinLeaveEventMessage : IActorMessage {}

	[Message(FrameOpcode.ConnectMessage)]
	public partial class ConnectMessage : IActorMessage {}

	[Message(FrameOpcode.OnlineStateBuffer)]
	public partial class OnlineStateBuffer : IActorMessage {}

	[Message(FrameOpcode.InputHeader)]
	public partial class InputHeader : IActorMessage {}

	[Message(FrameOpcode.InputPredictionWarmValues)]
	public partial class InputPredictionWarmValues : IActorMessage {}

	[Message(FrameOpcode.C2SOnlyInputState)]
	public partial class C2SOnlyInputState : IActorMessage {}

	[Message(FrameOpcode.MessageInputRLE)]
	public partial class MessageInputRLE {}

	[Message(FrameOpcode.MessageInputCoalesced)]
	public partial class MessageInputCoalesced {}

	[Message(FrameOpcode.MessageReceiveRemoteNCFAndJLE)]
	public partial class MessageReceiveRemoteNCFAndJLE {}

	[Message(FrameOpcode.MessageReceiveDesyncDebug)]
	public partial class MessageReceiveDesyncDebug {}

	[Message(FrameOpcode.C2SInputMessage)]
	public partial class C2SInputMessage : IActorMessage {}

	[Message(FrameOpcode.C2SCoalesceInput)]
	public partial class C2SCoalesceInput : IActorMessage {}

	[Message(FrameOpcode.S2CCoalesceInput)]
	public partial class S2CCoalesceInput : IActorMessage {}

}
namespace ETModel
{
	public static partial class FrameOpcode
	{
		 public const ushort OneFrameMessage = 20001;
		 public const ushort FrameMessage = 20002;
		 public const ushort PeerInfo = 20003;
		 public const ushort MoveInfo = 20004;
		 public const ushort UnitSnatshot = 20005;
		 public const ushort UnitSnapshotMsg = 20006;
		 public const ushort ClientInitComplete = 20007;
		 public const ushort SnapShotMessage = 20008;
		 public const ushort LocalNCFAndJLE = 20009;
		 public const ushort JoinEvent = 20010;
		 public const ushort JoinLeaveEventMessage = 20011;
		 public const ushort ConnectMessage = 20012;
		 public const ushort OnlineStateBuffer = 20013;
		 public const ushort InputHeader = 20014;
		 public const ushort InputPredictionWarmValues = 20015;
		 public const ushort C2SOnlyInputState = 20016;
		 public const ushort MessageInputRLE = 20017;
		 public const ushort MessageInputCoalesced = 20018;
		 public const ushort MessageReceiveRemoteNCFAndJLE = 20019;
		 public const ushort MessageReceiveDesyncDebug = 20020;
		 public const ushort C2SInputMessage = 20021;
		 public const ushort C2SCoalesceInput = 20022;
		 public const ushort S2CCoalesceInput = 20023;
	}
}
