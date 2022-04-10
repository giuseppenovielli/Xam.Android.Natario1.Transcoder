using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Internal.Audio.Remix {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.audio.remix']/class[@name='DownMixAudioRemixer']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/internal/audio/remix/DownMixAudioRemixer", DoNotGenerateAcw=true)]
	public partial class DownMixAudioRemixer : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/internal/audio/remix/DownMixAudioRemixer", typeof (DownMixAudioRemixer));

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

		protected DownMixAudioRemixer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.audio.remix']/class[@name='DownMixAudioRemixer']/constructor[@name='DownMixAudioRemixer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DownMixAudioRemixer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getRemixedSize_I;
#pragma warning disable 0169
		static Delegate GetGetRemixedSize_IHandler ()
		{
			if (cb_getRemixedSize_I == null)
				cb_getRemixedSize_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetRemixedSize_I);
			return cb_getRemixedSize_I;
		}

		static int n_GetRemixedSize_I (IntPtr jnienv, IntPtr native__this, int inputSize)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Audio.Remix.DownMixAudioRemixer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetRemixedSize (inputSize);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.audio.remix']/class[@name='DownMixAudioRemixer']/method[@name='getRemixedSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getRemixedSize", "(I)I", "GetGetRemixedSize_IHandler")]
		public virtual unsafe int GetRemixedSize (int inputSize)
		{
			const string __id = "getRemixedSize.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (inputSize);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_remix_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_;
#pragma warning disable 0169
		static Delegate GetRemix_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_Handler ()
		{
			if (cb_remix_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_ == null)
				cb_remix_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Remix_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_);
			return cb_remix_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_;
		}

		static void n_Remix_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inputBuffer, IntPtr native_outputBuffer)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Audio.Remix.DownMixAudioRemixer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var inputBuffer = global::Java.Lang.Object.GetObject<global::Java.Nio.ShortBuffer> (native_inputBuffer, JniHandleOwnership.DoNotTransfer);
			var outputBuffer = global::Java.Lang.Object.GetObject<global::Java.Nio.ShortBuffer> (native_outputBuffer, JniHandleOwnership.DoNotTransfer);
			__this.Remix (inputBuffer, outputBuffer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.audio.remix']/class[@name='DownMixAudioRemixer']/method[@name='remix' and count(parameter)=2 and parameter[1][@type='java.nio.ShortBuffer'] and parameter[2][@type='java.nio.ShortBuffer']]"
		[Register ("remix", "(Ljava/nio/ShortBuffer;Ljava/nio/ShortBuffer;)V", "GetRemix_Ljava_nio_ShortBuffer_Ljava_nio_ShortBuffer_Handler")]
		public virtual unsafe void Remix (global::Java.Nio.ShortBuffer inputBuffer, global::Java.Nio.ShortBuffer outputBuffer)
		{
			const string __id = "remix.(Ljava/nio/ShortBuffer;Ljava/nio/ShortBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((inputBuffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inputBuffer).Handle);
				__args [1] = new JniArgumentValue ((outputBuffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputBuffer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (inputBuffer);
				global::System.GC.KeepAlive (outputBuffer);
			}
		}

	}
}
