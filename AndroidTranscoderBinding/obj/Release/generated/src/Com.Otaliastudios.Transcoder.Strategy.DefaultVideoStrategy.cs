using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Strategy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultVideoStrategy']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/strategy/DefaultVideoStrategy", DoNotGenerateAcw=true)]
	public partial class DefaultVideoStrategy : global::Java.Lang.Object, global::Com.Otaliastudios.Transcoder.Strategy.ITrackStrategy {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultVideoStrategy']/field[@name='BITRATE_UNKNOWN']"
		[Register ("BITRATE_UNKNOWN")]
		public const long BitrateUnknown = (long) -9223372036854775808;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultVideoStrategy']/field[@name='DEFAULT_FRAME_RATE']"
		[Register ("DEFAULT_FRAME_RATE")]
		public const int DefaultFrameRate = (int) 30;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultVideoStrategy']/field[@name='DEFAULT_KEY_FRAME_INTERVAL']"
		[Register ("DEFAULT_KEY_FRAME_INTERVAL")]
		public const float DefaultKeyFrameInterval = (float) 3;

		// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultVideoStrategy.Builder']"
		[global::Android.Runtime.Register ("com/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Builder", typeof (Builder));

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultVideoStrategy.Builder']/constructor[@name='DefaultVideoStrategy.Builder' and count(parameter)=0]"
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultVideoStrategy.Builder']/constructor[@name='DefaultVideoStrategy.Builder' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.resize.Resizer']]"
			[Register (".ctor", "(Lcom/otaliastudios/transcoder/resize/Resizer;)V", "")]
			public unsafe Builder (global::Com.Otaliastudios.Transcoder.Resize.IResizer resizer) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/otaliastudios/transcoder/resize/Resizer;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((resizer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resizer).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (resizer);
				}
			}

			static Delegate cb_addResizer_Lcom_otaliastudios_transcoder_resize_Resizer_;
#pragma warning disable 0169
			static Delegate GetAddResizer_Lcom_otaliastudios_transcoder_resize_Resizer_Handler ()
			{
				if (cb_addResizer_Lcom_otaliastudios_transcoder_resize_Resizer_ == null)
					cb_addResizer_Lcom_otaliastudios_transcoder_resize_Resizer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddResizer_Lcom_otaliastudios_transcoder_resize_Resizer_);
				return cb_addResizer_Lcom_otaliastudios_transcoder_resize_Resizer_;
			}

			static IntPtr n_AddResizer_Lcom_otaliastudios_transcoder_resize_Resizer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_resizer)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var resizer = (global::Com.Otaliastudios.Transcoder.Resize.IResizer)global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Resize.IResizer> (native_resizer, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddResizer (resizer));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultVideoStrategy.Builder']/method[@name='addResizer' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.resize.Resizer']]"
			[Register ("addResizer", "(Lcom/otaliastudios/transcoder/resize/Resizer;)Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Builder;", "GetAddResizer_Lcom_otaliastudios_transcoder_resize_Resizer_Handler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder AddResizer (global::Com.Otaliastudios.Transcoder.Resize.IResizer resizer)
			{
				const string __id = "addResizer.(Lcom/otaliastudios/transcoder/resize/Resizer;)Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((resizer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resizer).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (resizer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.BitRate (bitRate));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultVideoStrategy.Builder']/method[@name='bitRate' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("bitRate", "(J)Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Builder;", "GetBitRate_JHandler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder BitRate (long bitRate)
			{
				const string __id = "bitRate.(J)Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (bitRate);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultVideoStrategy.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy;", "GetBuildHandler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy Build ()
			{
				const string __id = "build.()Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_frameRate_I;
#pragma warning disable 0169
			static Delegate GetFrameRate_IHandler ()
			{
				if (cb_frameRate_I == null)
					cb_frameRate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_FrameRate_I);
				return cb_frameRate_I;
			}

			static IntPtr n_FrameRate_I (IntPtr jnienv, IntPtr native__this, int frameRate)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.FrameRate (frameRate));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultVideoStrategy.Builder']/method[@name='frameRate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("frameRate", "(I)Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Builder;", "GetFrameRate_IHandler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder FrameRate (int frameRate)
			{
				const string __id = "frameRate.(I)Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (frameRate);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_keyFrameInterval_F;
#pragma warning disable 0169
			static Delegate GetKeyFrameInterval_FHandler ()
			{
				if (cb_keyFrameInterval_F == null)
					cb_keyFrameInterval_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_L) n_KeyFrameInterval_F);
				return cb_keyFrameInterval_F;
			}

			static IntPtr n_KeyFrameInterval_F (IntPtr jnienv, IntPtr native__this, float keyFrameInterval)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.KeyFrameInterval (keyFrameInterval));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultVideoStrategy.Builder']/method[@name='keyFrameInterval' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("keyFrameInterval", "(F)Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Builder;", "GetKeyFrameInterval_FHandler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder KeyFrameInterval (float keyFrameInterval)
			{
				const string __id = "keyFrameInterval.(F)Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (keyFrameInterval);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var mimeType = JNIEnv.GetString (native_mimeType, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MimeType (mimeType));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultVideoStrategy.Builder']/method[@name='mimeType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("mimeType", "(Ljava/lang/String;)Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Builder;", "GetMimeType_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder MimeType (string mimeType)
			{
				const string __id = "mimeType.(Ljava/lang/String;)Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Builder;";
				IntPtr native_mimeType = JNIEnv.NewString (mimeType);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_mimeType);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Options ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultVideoStrategy.Builder']/method[@name='options' and count(parameter)=0]"
			[Register ("options", "()Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Options;", "GetOptionsHandler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Options Options ()
			{
				const string __id = "options.()Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Options;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Options> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultVideoStrategy.Options']"
		[global::Android.Runtime.Register ("com/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Options", DoNotGenerateAcw=true)]
		public partial class Options : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Options", typeof (Options));

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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/strategy/DefaultVideoStrategy", typeof (DefaultVideoStrategy));

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

		protected DefaultVideoStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultVideoStrategy']/constructor[@name='DefaultVideoStrategy' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.strategy.DefaultVideoStrategy.Options']]"
		[Register (".ctor", "(Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Options;)V", "")]
		public unsafe DefaultVideoStrategy (global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Options options) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Options;)V";

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultVideoStrategy']/method[@name='aspectRatio' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("aspectRatio", "(F)Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Builder;", "")]
		public static unsafe global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder AspectRatio (float aspectRatio)
		{
			const string __id = "aspectRatio.(F)Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (aspectRatio);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultVideoStrategy']/method[@name='atMost' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("atMost", "(I)Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Builder;", "")]
		public static unsafe global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder AtMost (int atMostSize)
		{
			const string __id = "atMost.(I)Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (atMostSize);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultVideoStrategy']/method[@name='atMost' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("atMost", "(II)Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Builder;", "")]
		public static unsafe global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder AtMost (int atMostMinor, int atMostMajor)
		{
			const string __id = "atMost.(II)Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (atMostMinor);
				__args [1] = new JniArgumentValue (atMostMajor);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var inputFormats = global::Android.Runtime.JavaList<global::Android.Media.MediaFormat>.FromJniHandle (native_inputFormats, JniHandleOwnership.DoNotTransfer);
			var outputFormat = global::Java.Lang.Object.GetObject<global::Android.Media.MediaFormat> (native_outputFormat, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateOutputFormat (inputFormats, outputFormat));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultVideoStrategy']/method[@name='createOutputFormat' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;android.media.MediaFormat&gt;'] and parameter[2][@type='android.media.MediaFormat']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultVideoStrategy']/method[@name='exact' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("exact", "(II)Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Builder;", "")]
		public static unsafe global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder Exact (int firstSize, int secondSize)
		{
			const string __id = "exact.(II)Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (firstSize);
				__args [1] = new JniArgumentValue (secondSize);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='DefaultVideoStrategy']/method[@name='fraction' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("fraction", "(F)Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Builder;", "")]
		public static unsafe global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder Fraction (float fraction)
		{
			const string __id = "fraction.(F)Lcom/otaliastudios/transcoder/strategy/DefaultVideoStrategy$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (fraction);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.DefaultVideoStrategy.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
