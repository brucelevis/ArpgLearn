// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: HotfixMessageServer.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using scg = global::System.Collections.Generic;
namespace ETHotfix {

  #region Messages
  public partial class C2R_Login : pb::IMessage {
    private static readonly pb::MessageParser<C2R_Login> _parser = new pb::MessageParser<C2R_Login>(() => new C2R_Login());
    public static pb::MessageParser<C2R_Login> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private string account_ = "";
    /// <summary>
    /// 帐号
    /// </summary>
    public string Account {
      get { return account_; }
      set {
        account_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private string password_ = "";
    /// <summary>
    /// 密码
    /// </summary>
    public string Password {
      get { return password_; }
      set {
        password_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Account.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Account);
      }
      if (Password.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Password);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (Account.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Account);
      }
      if (Password.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Password);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      account_ = "";
      password_ = "";
      rpcId_ = 0;
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Account = input.ReadString();
            break;
          }
          case 18: {
            Password = input.ReadString();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public partial class R2C_Login : pb::IMessage {
    private static readonly pb::MessageParser<R2C_Login> _parser = new pb::MessageParser<R2C_Login>(() => new R2C_Login());
    public static pb::MessageParser<R2C_Login> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private int error_;
    public int Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    private string message_ = "";
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private string address_ = "";
    public string Address {
      get { return address_; }
      set {
        address_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private long key_;
    public long Key {
      get { return key_; }
      set {
        key_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Address.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Address);
      }
      if (Key != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Key);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
      if (Error != 0) {
        output.WriteRawTag(216, 5);
        output.WriteInt32(Error);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(226, 5);
        output.WriteString(Message);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (Error != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Error);
      }
      if (Message.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (Address.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Address);
      }
      if (Key != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Key);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      address_ = "";
      key_ = 0;
      rpcId_ = 0;
      error_ = 0;
      message_ = "";
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Address = input.ReadString();
            break;
          }
          case 16: {
            Key = input.ReadInt64();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
          case 728: {
            Error = input.ReadInt32();
            break;
          }
          case 738: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public partial class C2G_LoginGate : pb::IMessage {
    private static readonly pb::MessageParser<C2G_LoginGate> _parser = new pb::MessageParser<C2G_LoginGate>(() => new C2G_LoginGate());
    public static pb::MessageParser<C2G_LoginGate> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private long key_;
    /// <summary>
    /// 帐号
    /// </summary>
    public long Key {
      get { return key_; }
      set {
        key_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Key != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Key);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (Key != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Key);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      key_ = 0;
      rpcId_ = 0;
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Key = input.ReadInt64();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public partial class G2C_LoginGate : pb::IMessage {
    private static readonly pb::MessageParser<G2C_LoginGate> _parser = new pb::MessageParser<G2C_LoginGate>(() => new G2C_LoginGate());
    public static pb::MessageParser<G2C_LoginGate> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private int error_;
    public int Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    private string message_ = "";
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private long playerId_;
    public long PlayerId {
      get { return playerId_; }
      set {
        playerId_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (PlayerId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(PlayerId);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
      if (Error != 0) {
        output.WriteRawTag(216, 5);
        output.WriteInt32(Error);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(226, 5);
        output.WriteString(Message);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (Error != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Error);
      }
      if (Message.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (PlayerId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(PlayerId);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      playerId_ = 0;
      rpcId_ = 0;
      error_ = 0;
      message_ = "";
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            PlayerId = input.ReadInt64();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
          case 728: {
            Error = input.ReadInt32();
            break;
          }
          case 738: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public partial class C2G_SendMsg : pb::IMessage {
    private static readonly pb::MessageParser<C2G_SendMsg> _parser = new pb::MessageParser<C2G_SendMsg>(() => new C2G_SendMsg());
    public static pb::MessageParser<C2G_SendMsg> Parser { get { return _parser; } }

    private string info_ = "";
    public string Info {
      get { return info_; }
      set {
        info_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Info.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Info);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Info.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Info);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      info_ = "";
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Info = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public partial class G2C_TestHotfixMessage : pb::IMessage {
    private static readonly pb::MessageParser<G2C_TestHotfixMessage> _parser = new pb::MessageParser<G2C_TestHotfixMessage>(() => new G2C_TestHotfixMessage());
    public static pb::MessageParser<G2C_TestHotfixMessage> Parser { get { return _parser; } }

    private string info_ = "";
    public string Info {
      get { return info_; }
      set {
        info_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Info.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Info);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Info.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Info);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      info_ = "";
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Info = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public partial class C2M_TestActorRequest : pb::IMessage {
    private static readonly pb::MessageParser<C2M_TestActorRequest> _parser = new pb::MessageParser<C2M_TestActorRequest>(() => new C2M_TestActorRequest());
    public static pb::MessageParser<C2M_TestActorRequest> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private long actorId_;
    public long ActorId {
      get { return actorId_; }
      set {
        actorId_ = value;
      }
    }

    private string info_ = "";
    public string Info {
      get { return info_; }
      set {
        info_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Info.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Info);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
      if (ActorId != 0L) {
        output.WriteRawTag(216, 5);
        output.WriteInt64(ActorId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (ActorId != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(ActorId);
      }
      if (Info.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Info);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      info_ = "";
      rpcId_ = 0;
      actorId_ = 0;
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Info = input.ReadString();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
          case 728: {
            ActorId = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  public partial class M2C_TestActorResponse : pb::IMessage {
    private static readonly pb::MessageParser<M2C_TestActorResponse> _parser = new pb::MessageParser<M2C_TestActorResponse>(() => new M2C_TestActorResponse());
    public static pb::MessageParser<M2C_TestActorResponse> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private int error_;
    public int Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    private string message_ = "";
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private string info_ = "";
    public string Info {
      get { return info_; }
      set {
        info_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Info.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Info);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
      if (Error != 0) {
        output.WriteRawTag(216, 5);
        output.WriteInt32(Error);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(226, 5);
        output.WriteString(Message);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (Error != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Error);
      }
      if (Message.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (Info.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Info);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      info_ = "";
      rpcId_ = 0;
      error_ = 0;
      message_ = "";
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Info = input.ReadString();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
          case 728: {
            Error = input.ReadInt32();
            break;
          }
          case 738: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public partial class PlayerInfo : pb::IMessage {
    private static readonly pb::MessageParser<PlayerInfo> _parser = new pb::MessageParser<PlayerInfo>(() => new PlayerInfo());
    public static pb::MessageParser<PlayerInfo> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      rpcId_ = 0;
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public partial class C2G_PlayerInfo : pb::IMessage {
    private static readonly pb::MessageParser<C2G_PlayerInfo> _parser = new pb::MessageParser<C2G_PlayerInfo>(() => new C2G_PlayerInfo());
    public static pb::MessageParser<C2G_PlayerInfo> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      rpcId_ = 0;
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public partial class G2C_PlayerInfo : pb::IMessage {
    private static readonly pb::MessageParser<G2C_PlayerInfo> _parser = new pb::MessageParser<G2C_PlayerInfo>(() => new G2C_PlayerInfo());
    public static pb::MessageParser<G2C_PlayerInfo> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private int error_;
    public int Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    private string message_ = "";
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private global::ETHotfix.PlayerInfo playerInfos_;
    public global::ETHotfix.PlayerInfo PlayerInfos {
      get { return playerInfos_; }
      set {
        playerInfos_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (playerInfos_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(PlayerInfos);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
      if (Error != 0) {
        output.WriteRawTag(216, 5);
        output.WriteInt32(Error);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(226, 5);
        output.WriteString(Message);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (Error != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Error);
      }
      if (Message.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (playerInfos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerInfos);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      rpcId_ = 0;
      error_ = 0;
      message_ = "";
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (playerInfos_ == null) {
              playerInfos_ = new global::ETHotfix.PlayerInfo();
            }
            input.ReadMessage(playerInfos_);
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
          case 728: {
            Error = input.ReadInt32();
            break;
          }
          case 738: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
