using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Stretch {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.stretch']/class[@name='InsertAudioStretcher']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/stretch/InsertAudioStretcher", DoNotGenerateAcw=true)]
	public partial class InsertAudioStretcher : global::Java.Lang.Object, global::Com.Otaliastudios.Transcoder.Stretch.IAudioStretcher {
		public static class InterfaceConsts {
			// The following are fields from: com.otaliastudios.transcoder.stretch.AudioStretcher


			// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.stretch']/interface[@name='AudioStretcher']/field[@name='CUT']"
			[Register ("CUT")]
			public static global::Com.Otaliastudios.Transcoder.Stretch.IAudioStretcher Cut {
				get {
					const string __id = "CUT.Lcom/otaliastudios/transcoder/stretch/AudioStretcher;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Stretch.IAudioStretcher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.stretch']/interface[@name='AudioStretcher']/field[@name='INSERT']"
			[Register ("INSERT")]
			public static global::Com.Otaliastudios.Transcoder.Stretch.IAudioStretcher Insert {
				get {
					const string __id = "INSERT.Lcom/otaliastudios/transcoder/stretch/AudioStretcher;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Stretch.IAudioStretcher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.stretch']/interface[@name='AudioStretcher']/field[@name='PASSTHROUGH']"
			[Register ("PASSTHROUGH")]
			public static global::Com.Otaliastudios.Transcoder.Stretch.IAudioStretcher Passthrough {
				get {
					const string __id = "PASSTHROUGH.Lcom/otaliastudios/transcoder/stretch/AudioStretcher;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Stretch.IAudioStretcher> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/stretch/InsertAudioStretcher", typeof (InsertAudioStretcher));

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

		protected InsertAudioStretcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.stretch']/class[@name='InsertAudioStretcher']/constructor[@name='InsertAudioStretcher' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InsertAudioStretcher () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_stretch_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_I;
#pragma warning disable 0169
		static Delegate GetStretch_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_IHandler ()
		{
			if (cb_stretch_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_I == null)
				cb_stretch_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_Stretch_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_I);
			return cb_stretch_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_I;
		}

		static void n_Stretch_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_I (IntPtr jnienv, IntPtr native__this, IntPtr native_input, IntPtr native_output, int channels)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Stretch.InsertAudioStretcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var input = global::Java.Lang.Object.GetObject<global::Java.Nio.ShortBuffer> (native_input, JniHandleOwnership.DoNotTransfer);
			var output = global::Java.Lang.Object.GetObject<global::Java.Nio.ShortBuffer> (native_output, JniHandleOwnership.DoNotTransfer);
			__this.Stretch (input, output, channels);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.stretch']/class[@name='InsertAudioStretcher']/method[@name='stretch' and count(parameter)=3 and parameter[1][@type='java.nio.ShortBuffer'] and parameter[2][@type='java.nio.ShortBuffer'] and parameter[3][@type='int']]"
		[Register ("stretch", "(Ljava/nio/ShortBuffer;Ljava/nio/ShortBuffer;I)V", "GetStretch_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_IHandler")]
		public virtual unsafe void Stretch (global::Java.Nio.ShortBuffer input, global::Java.Nio.ShortBuffer output, int channels)
		{
			const string __id = "stretch.(Ljava/nio/ShortBuffer;Ljava/nio/ShortBuffer;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((input == null) ? IntPtr.Zero : ((global::Java.Lang.Object) input).Handle);
				__args [1] = new JniArgumentValue ((output == null) ? IntPtr.Zero : ((global::Java.Lang.Object) output).Handle);
				__args [2] = new JniArgumentValue (channels);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (input);
				global::System.GC.KeepAlive (output);
			}
		}

	}
}
