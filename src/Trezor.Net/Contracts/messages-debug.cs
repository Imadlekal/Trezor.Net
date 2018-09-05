// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: messages-debug.proto

#pragma warning disable CS1591, CS0612, CS3021, IDE1006
namespace hw.trezor.messages.debug
{

    [global::ProtoBuf.ProtoContract()]
    public partial class DebugLinkDecision : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"yes_no")]
        public bool YesNo
        {
            get { return __pbn__YesNo.GetValueOrDefault(); }
            set { __pbn__YesNo = value; }
        }
        public bool ShouldSerializeYesNo() => __pbn__YesNo != null;
        public void ResetYesNo() => __pbn__YesNo = null;
        private bool? __pbn__YesNo;

        [global::ProtoBuf.ProtoMember(2, Name = @"up_down")]
        public bool UpDown
        {
            get { return __pbn__UpDown.GetValueOrDefault(); }
            set { __pbn__UpDown = value; }
        }
        public bool ShouldSerializeUpDown() => __pbn__UpDown != null;
        public void ResetUpDown() => __pbn__UpDown = null;
        private bool? __pbn__UpDown;

        [global::ProtoBuf.ProtoMember(3, Name = @"input")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Input
        {
            get { return __pbn__Input ?? ""; }
            set { __pbn__Input = value; }
        }
        public bool ShouldSerializeInput() => __pbn__Input != null;
        public void ResetInput() => __pbn__Input = null;
        private string __pbn__Input;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DebugLinkGetState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DebugLinkState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"layout")]
        public byte[] Layout
        {
            get { return __pbn__Layout; }
            set { __pbn__Layout = value; }
        }
        public bool ShouldSerializeLayout() => __pbn__Layout != null;
        public void ResetLayout() => __pbn__Layout = null;
        private byte[] __pbn__Layout;

        [global::ProtoBuf.ProtoMember(2, Name = @"pin")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Pin
        {
            get { return __pbn__Pin ?? ""; }
            set { __pbn__Pin = value; }
        }
        public bool ShouldSerializePin() => __pbn__Pin != null;
        public void ResetPin() => __pbn__Pin = null;
        private string __pbn__Pin;

        [global::ProtoBuf.ProtoMember(3, Name = @"matrix")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Matrix
        {
            get { return __pbn__Matrix ?? ""; }
            set { __pbn__Matrix = value; }
        }
        public bool ShouldSerializeMatrix() => __pbn__Matrix != null;
        public void ResetMatrix() => __pbn__Matrix = null;
        private string __pbn__Matrix;

        [global::ProtoBuf.ProtoMember(4, Name = @"mnemonic")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Mnemonic
        {
            get { return __pbn__Mnemonic ?? ""; }
            set { __pbn__Mnemonic = value; }
        }
        public bool ShouldSerializeMnemonic() => __pbn__Mnemonic != null;
        public void ResetMnemonic() => __pbn__Mnemonic = null;
        private string __pbn__Mnemonic;

        [global::ProtoBuf.ProtoMember(5, Name = @"node")]
        public global::hw.trezor.messages.common.HDNodeType Node { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"passphrase_protection")]
        public bool PassphraseProtection
        {
            get { return __pbn__PassphraseProtection.GetValueOrDefault(); }
            set { __pbn__PassphraseProtection = value; }
        }
        public bool ShouldSerializePassphraseProtection() => __pbn__PassphraseProtection != null;
        public void ResetPassphraseProtection() => __pbn__PassphraseProtection = null;
        private bool? __pbn__PassphraseProtection;

        [global::ProtoBuf.ProtoMember(7, Name = @"reset_word")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ResetWord
        {
            get { return __pbn__ResetWord ?? ""; }
            set { __pbn__ResetWord = value; }
        }
        public bool ShouldSerializeResetWord() => __pbn__ResetWord != null;
        public void ResetResetWord() => __pbn__ResetWord = null;
        private string __pbn__ResetWord;

        [global::ProtoBuf.ProtoMember(8, Name = @"reset_entropy")]
        public byte[] ResetEntropy
        {
            get { return __pbn__ResetEntropy; }
            set { __pbn__ResetEntropy = value; }
        }
        public bool ShouldSerializeResetEntropy() => __pbn__ResetEntropy != null;
        public void ResetResetEntropy() => __pbn__ResetEntropy = null;
        private byte[] __pbn__ResetEntropy;

        [global::ProtoBuf.ProtoMember(9, Name = @"recovery_fake_word")]
        [global::System.ComponentModel.DefaultValue("")]
        public string RecoveryFakeWord
        {
            get { return __pbn__RecoveryFakeWord ?? ""; }
            set { __pbn__RecoveryFakeWord = value; }
        }
        public bool ShouldSerializeRecoveryFakeWord() => __pbn__RecoveryFakeWord != null;
        public void ResetRecoveryFakeWord() => __pbn__RecoveryFakeWord = null;
        private string __pbn__RecoveryFakeWord;

        [global::ProtoBuf.ProtoMember(10, Name = @"recovery_word_pos")]
        public uint RecoveryWordPos
        {
            get { return __pbn__RecoveryWordPos.GetValueOrDefault(); }
            set { __pbn__RecoveryWordPos = value; }
        }
        public bool ShouldSerializeRecoveryWordPos() => __pbn__RecoveryWordPos != null;
        public void ResetRecoveryWordPos() => __pbn__RecoveryWordPos = null;
        private uint? __pbn__RecoveryWordPos;

        [global::ProtoBuf.ProtoMember(11, Name = @"reset_word_pos")]
        public uint ResetWordPos
        {
            get { return __pbn__ResetWordPos.GetValueOrDefault(); }
            set { __pbn__ResetWordPos = value; }
        }
        public bool ShouldSerializeResetWordPos() => __pbn__ResetWordPos != null;
        public void ResetResetWordPos() => __pbn__ResetWordPos = null;
        private uint? __pbn__ResetWordPos;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DebugLinkStop : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DebugLinkLog : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"level")]
        public uint Level
        {
            get { return __pbn__Level.GetValueOrDefault(); }
            set { __pbn__Level = value; }
        }
        public bool ShouldSerializeLevel() => __pbn__Level != null;
        public void ResetLevel() => __pbn__Level = null;
        private uint? __pbn__Level;

        [global::ProtoBuf.ProtoMember(2, Name = @"bucket")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Bucket
        {
            get { return __pbn__Bucket ?? ""; }
            set { __pbn__Bucket = value; }
        }
        public bool ShouldSerializeBucket() => __pbn__Bucket != null;
        public void ResetBucket() => __pbn__Bucket = null;
        private string __pbn__Bucket;

        [global::ProtoBuf.ProtoMember(3, Name = @"text")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Text
        {
            get { return __pbn__Text ?? ""; }
            set { __pbn__Text = value; }
        }
        public bool ShouldSerializeText() => __pbn__Text != null;
        public void ResetText() => __pbn__Text = null;
        private string __pbn__Text;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DebugLinkMemoryRead : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address")]
        public uint Address
        {
            get { return __pbn__Address.GetValueOrDefault(); }
            set { __pbn__Address = value; }
        }
        public bool ShouldSerializeAddress() => __pbn__Address != null;
        public void ResetAddress() => __pbn__Address = null;
        private uint? __pbn__Address;

        [global::ProtoBuf.ProtoMember(2, Name = @"length")]
        public uint Length
        {
            get { return __pbn__Length.GetValueOrDefault(); }
            set { __pbn__Length = value; }
        }
        public bool ShouldSerializeLength() => __pbn__Length != null;
        public void ResetLength() => __pbn__Length = null;
        private uint? __pbn__Length;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DebugLinkMemory : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"memory")]
        public byte[] Memory
        {
            get { return __pbn__Memory; }
            set { __pbn__Memory = value; }
        }
        public bool ShouldSerializeMemory() => __pbn__Memory != null;
        public void ResetMemory() => __pbn__Memory = null;
        private byte[] __pbn__Memory;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DebugLinkMemoryWrite : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address")]
        public uint Address
        {
            get { return __pbn__Address.GetValueOrDefault(); }
            set { __pbn__Address = value; }
        }
        public bool ShouldSerializeAddress() => __pbn__Address != null;
        public void ResetAddress() => __pbn__Address = null;
        private uint? __pbn__Address;

        [global::ProtoBuf.ProtoMember(2, Name = @"memory")]
        public byte[] Memory
        {
            get { return __pbn__Memory; }
            set { __pbn__Memory = value; }
        }
        public bool ShouldSerializeMemory() => __pbn__Memory != null;
        public void ResetMemory() => __pbn__Memory = null;
        private byte[] __pbn__Memory;

        [global::ProtoBuf.ProtoMember(3, Name = @"flash")]
        public bool Flash
        {
            get { return __pbn__Flash.GetValueOrDefault(); }
            set { __pbn__Flash = value; }
        }
        public bool ShouldSerializeFlash() => __pbn__Flash != null;
        public void ResetFlash() => __pbn__Flash = null;
        private bool? __pbn__Flash;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DebugLinkFlashErase : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"sector")]
        public uint Sector
        {
            get { return __pbn__Sector.GetValueOrDefault(); }
            set { __pbn__Sector = value; }
        }
        public bool ShouldSerializeSector() => __pbn__Sector != null;
        public void ResetSector() => __pbn__Sector = null;
        private uint? __pbn__Sector;

    }

}

#pragma warning restore CS1591, CS0612, CS3021, IDE1006
