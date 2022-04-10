using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Strategy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultAudioStrategy']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/strategy/DefaultAudioStrategy", DoNotGenerateAcw=true)]
	public partial class DefaultAudioStrategy : global::Java.Lang.Object, global::Com.Otaliastudios.Transcoder.Strategy.ITrackStrategy {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultAudioStrategy']/field[@name='BITRATE_UNKNOWN']"
		[Register ("BITRATE_UNKNOWN")]
		public const long BitrateUnknown = (long) -9223372036854775808;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultAudioStrategy']/field[@name='CHANNELS_AS_INPUT']"
		[Register ("CHANNELS_AS_INPUT")]
		public const int ChannelsAsInput = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultAudioStrategy']/field[@name='SAMPLE_RATE_AS_INPUT']"
		[Register ("SAMPLE_RATE_AS_INPUT")]
		public const int SampleRateAsInput = (int) -1;

		// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultAudioStrategy.Builder']"
		[global::Android.Runtime.Register ("com/otaliastudios/transcoder/strategy/DefaultAudioStrategy$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/strategy/DefaultAudioStrategy$Builder", typeof (Builder));

			internal static IntPtr class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultAudioStrategy.Builder']/constructor[@name='DefaultAudioStrategy.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_bitRate_J;
#pragma warning disable 0169
			static Delegate GetBitRate_JHandler ()
			{
				if (cb_bitRate_J == null)
					cb_bitRate_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_BitRate_J);
				return cb_bitRate_J;
			}

			static IntPtr n_BitRate_J (IntPtr jnienv, IntPtr native__this, long bitRate)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultAudioStrategy.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.BitRate (bitRate));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultAudioStrategy.Builder']/method[@name='bitRate' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("bitRate", "(J)Lcom/otaliastudios/transcoder/strategy/DefaultAudioStrategy$Builder;", "GetBitRate_JHandler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.Strategy.DefaultAudioStrategy.Builder BitRate (long bitRate)
			{
				const string __id = "bitRate.(J)Lcom/otaliastudios/transcoder/strategy/DefaultAudioStrategy$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (bitRate);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultAudioStrategy.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultAudioStrategy.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultAudioStrategy.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/otaliastudios/transcoder/strategy/DefaultAudioStrategy;", "GetBuildHandler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.Strategy.DefaultAudioStrategy Build ()
			{
				const string __id = "build.()Lcom/otaliastudios/transcoder/strategy/DefaultAudioStrategy;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultAudioStrategy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_channels_I;
#pragma warning disable 0169
			static Delegate GetChannels_IHandler ()
			{
				if (cb_channels_I == null)
					cb_channels_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Channels_I);
				return cb_channels_I;
			}

			static IntPtr n_Channels_I (IntPtr jnienv, IntPtr native__this, int channels)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultAudioStrategy.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Channels (channels));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultAudioStrategy.Builder']/method[@name='channels' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("channels", "(I)Lcom/otaliastudios/transcoder/strategy/DefaultAudioStrategy$Builder;", "GetChannels_IHandler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.Strategy.DefaultAudioStrategy.Builder Channels (int channels)
			{
				const string __id = "channels.(I)Lcom/otaliastudios/transcoder/strategy/DefaultAudioStrategy$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (channels);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultAudioStrategy.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_mimeType_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetMimeType_Ljava_lang_String_Handler ()
			{
				if (cb_mimeType_Ljava_lang_String_ == null)
					cb_mimeType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_MimeType_Ljava_lang_String_);
				return cb_mimeType_Ljava_lang_String_;
			}

			static IntPtr n_MimeType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mimeType)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultAudioStrategy.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var mimeType = JNIEnv.GetString (native_mimeType, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MimeType (mimeType));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultAudioStrategy.Builder']/method[@name='mimeType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("mimeType", "(Ljava/lang/String;)Lcom/otaliastudios/transcoder/strategy/DefaultAudioStrategy$Builder;", "GetMimeType_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.Strategy.DefaultAudioStrategy.Builder MimeType (string mimeType)
			{
				const string __id = "mimeType.(Ljava/lang/String;)Lcom/otaliastudios/transcoder/strategy/DefaultAudioStrategy$Builder;";
				IntPtr native_mimeType = JNIEnv.NewString (mimeType);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_mimeType);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultAudioStrategy.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_mimeType);
				}
			}

			static Delegate cb_options;
#pragma warning disable 0169
			static Delegate GetOptionsHandler ()
			{
				if (cb_options == null)
					cb_options = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Options);
				return cb_options;
			}

			static IntPtr n_Options (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultAudioStrategy.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Options ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultAudioStrategy.Builder']/method[@name='options' and count(parameter)=0]"
			[Register ("options", "()Lcom/otaliastudios/transcoder/strategy/DefaultAudioStrategy$Options;", "GetOptionsHandler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.Strategy.DefaultAudioStrategy.Options Options ()
			{
				const string __id = "options.()Lcom/otaliastudios/transcoder/strategy/DefaultAudioStrategy$Options;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultAudioStrategy.Options> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_sampleRate_I;
#pragma warning disable 0169
			static Delegate GetSampleRate_IHandler ()
			{
				if (cb_sampleRate_I == null)
					cb_sampleRate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SampleRate_I);
				return cb_sampleRate_I;
			}

			static IntPtr n_SampleRate_I (IntPtr jnienv, IntPtr native__this, int sampleRate)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultAudioStrategy.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SampleRate (sampleRate));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultAudioStrategy.Builder']/method[@name='sampleRate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("sampleRate", "(I)Lcom/otaliastudios/transcoder/strategy/DefaultAudioStrategy$Builder;", "GetSampleRate_IHandler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.Strategy.DefaultAudioStrategy.Builder SampleRate (int sampleRate)
			{
				const string __id = "sampleRate.(I)Lcom/otaliastudios/transcoder/strategy/DefaultAudioStrategy$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (sampleRate);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultAudioStrategy.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultAudioStrategy.Options']"
		[global::Android.Runtime.Register ("com/otaliastudios/transcoder/strategy/DefaultAudioStrategy$Options", DoNotGenerateAcw=true)]
		public partial class Options : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/strategy/DefaultAudioStrategy$Options", typeof (Options));

			internal static IntPtr class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected Options (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/strategy/DefaultAudioStrategy", typeof (DefaultAudioStrategy));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected DefaultAudioStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultAudioStrategy']/constructor[@name='DefaultAudioStrategy' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.strategy.DefaultAudioStrategy.Options']]"
		[Register (".ctor", "(Lcom/otaliastudios/transcoder/strategy/DefaultAudioStrategy$Options;)V", "")]
		public unsafe DefaultAudioStrategy (global::Com.Otaliastudios.Transcoder.Strategy.DefaultAudioStrategy.Options options) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/otaliastudios/transcoder/strategy/DefaultAudioStrategy$Options;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (options);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultAudioStrategy']/method[@name='builder' and count(parameter)=0]"
		[Register ("builder", "()Lcom/otaliastudios/transcoder/strategy/DefaultAudioStrategy$Builder;", "")]
		public static unsafe global::Com.Otaliastudios.Transcoder.Strategy.DefaultAudioStrategy.Builder InvokeBuilder ()
		{
			const string __id = "builder.()Lcom/otaliastudios/transcoder/strategy/DefaultAudioStrategy$Builder;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultAudioStrategy.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_;
#pragma warning disable 0169
		static Delegate GetCreateOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_Handler ()
		{
			if (cb_createOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_ == null)
				cb_createOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_CreateOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_);
			return cb_createOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_;
		}

		static IntPtr n_CreateOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inputFormats, IntPtr native_outputFormat)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultAudioStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var inputFormats = global::Android.Runtime.JavaList<global::Android.Media.MediaFormat>.FromJniHandle (native_inputFormats, JniHandleOwnership.DoNotTransfer);
			var outputFormat = global::Java.Lang.Object.GetObject<global::Android.Media.MediaFormat> (native_outputFormat, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateOutputFormat (inputFormats, outputFormat));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultAudioStrategy']/method[@name='createOutputFormat' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;android.media.MediaFormat&gt;'] and parameter[2][@type='android.media.MediaFormat']]"
		[Register ("createOutputFormat", "(Ljava/util/List;Landroid/media/MediaFormat;)Lcom/otaliastudios/transcoder/common/TrackStatus;", "GetCreateOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_Handler")]
		public virtual unsafe global::Com.Otaliastudios.Transcoder.Common.TrackStatus CreateOutputFormat (global::System.Collections.Generic.IList<global::Android.Media.MediaFormat> inputFormats, global::Android.Media.MediaFormat outputFormat)
		{
			const string __id = "createOutputFormat.(Ljava/util/List;Landroid/media/MediaFormat;)Lcom/otaliastudios/transcoder/common/TrackStatus;";
			IntPtr native_inputFormats = global::Android.Runtime.JavaList<global::Android.Media.MediaFormat>.ToLocalJniHandle (inputFormats);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_inputFormats);
				__args [1] = new JniArgumentValue ((outputFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputFormat).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_inputFormats);
				global::System.GC.KeepAlive (inputFormats);
				global::System.GC.KeepAlive (outputFormat);
			}
		}

	}
}
