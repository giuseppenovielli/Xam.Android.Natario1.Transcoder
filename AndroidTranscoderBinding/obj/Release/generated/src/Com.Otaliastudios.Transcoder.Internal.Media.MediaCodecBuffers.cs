using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Internal.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.media']/class[@name='MediaCodecBuffers']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/internal/media/MediaCodecBuffers", DoNotGenerateAcw=true)]
	public partial class MediaCodecBuffers : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/internal/media/MediaCodecBuffers", typeof (MediaCodecBuffers));

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

		protected MediaCodecBuffers (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.media']/class[@name='MediaCodecBuffers']/constructor[@name='MediaCodecBuffers' and count(parameter)=1 and parameter[1][@type='android.media.MediaCodec']]"
		[Register (".ctor", "(Landroid/media/MediaCodec;)V", "")]
		public unsafe MediaCodecBuffers (global::Android.Media.MediaCodec mediaCodec) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/media/MediaCodec;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mediaCodec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaCodec).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mediaCodec);
			}
		}

		static Delegate cb_getInputBuffer_I;
#pragma warning disable 0169
		static Delegate GetGetInputBuffer_IHandler ()
		{
			if (cb_getInputBuffer_I == null)
				cb_getInputBuffer_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetInputBuffer_I);
			return cb_getInputBuffer_I;
		}

		static IntPtr n_GetInputBuffer_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Media.MediaCodecBuffers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetInputBuffer (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.media']/class[@name='MediaCodecBuffers']/method[@name='getInputBuffer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getInputBuffer", "(I)Ljava/nio/ByteBuffer;", "GetGetInputBuffer_IHandler")]
		public virtual unsafe global::Java.Nio.ByteBuffer GetInputBuffer (int index)
		{
			const string __id = "getInputBuffer.(I)Ljava/nio/ByteBuffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getOutputBuffer_I;
#pragma warning disable 0169
		static Delegate GetGetOutputBuffer_IHandler ()
		{
			if (cb_getOutputBuffer_I == null)
				cb_getOutputBuffer_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetOutputBuffer_I);
			return cb_getOutputBuffer_I;
		}

		static IntPtr n_GetOutputBuffer_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Media.MediaCodecBuffers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetOutputBuffer (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.media']/class[@name='MediaCodecBuffers']/method[@name='getOutputBuffer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getOutputBuffer", "(I)Ljava/nio/ByteBuffer;", "GetGetOutputBuffer_IHandler")]
		public virtual unsafe global::Java.Nio.ByteBuffer GetOutputBuffer (int index)
		{
			const string __id = "getOutputBuffer.(I)Ljava/nio/ByteBuffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onOutputBuffersChanged;
#pragma warning disable 0169
		static Delegate GetOnOutputBuffersChangedHandler ()
		{
			if (cb_onOutputBuffersChanged == null)
				cb_onOutputBuffersChanged = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnOutputBuffersChanged);
			return cb_onOutputBuffersChanged;
		}

		static void n_OnOutputBuffersChanged (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Media.MediaCodecBuffers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnOutputBuffersChanged ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.media']/class[@name='MediaCodecBuffers']/method[@name='onOutputBuffersChanged' and count(parameter)=0]"
		[Register ("onOutputBuffersChanged", "()V", "GetOnOutputBuffersChangedHandler")]
		public virtual unsafe void OnOutputBuffersChanged ()
		{
			const string __id = "onOutputBuffersChanged.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
