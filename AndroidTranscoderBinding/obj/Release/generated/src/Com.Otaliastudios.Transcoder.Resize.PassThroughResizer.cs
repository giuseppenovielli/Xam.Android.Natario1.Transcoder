using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Resize {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.resize']/class[@name='PassThroughResizer']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/resize/PassThroughResizer", DoNotGenerateAcw=true)]
	public partial class PassThroughResizer : global::Java.Lang.Object, global::Com.Otaliastudios.Transcoder.Resize.IResizer {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/resize/PassThroughResizer", typeof (PassThroughResizer));

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

		protected PassThroughResizer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.resize']/class[@name='PassThroughResizer']/constructor[@name='PassThroughResizer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PassThroughResizer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getOutputSize_Lcom_otaliastudios_transcoder_common_Size_;
#pragma warning disable 0169
		static Delegate GetGetOutputSize_Lcom_otaliastudios_transcoder_common_Size_Handler ()
		{
			if (cb_getOutputSize_Lcom_otaliastudios_transcoder_common_Size_ == null)
				cb_getOutputSize_Lcom_otaliastudios_transcoder_common_Size_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetOutputSize_Lcom_otaliastudios_transcoder_common_Size_);
			return cb_getOutputSize_Lcom_otaliastudios_transcoder_common_Size_;
		}

		static IntPtr n_GetOutputSize_Lcom_otaliastudios_transcoder_common_Size_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inputSize)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Resize.PassThroughResizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var inputSize = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.Size> (native_inputSize, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetOutputSize (inputSize));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.resize']/class[@name='PassThroughResizer']/method[@name='getOutputSize' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.common.Size']]"
		[Register ("getOutputSize", "(Lcom/otaliastudios/transcoder/common/Size;)Lcom/otaliastudios/transcoder/common/Size;", "GetGetOutputSize_Lcom_otaliastudios_transcoder_common_Size_Handler")]
		public virtual unsafe global::Com.Otaliastudios.Transcoder.Common.Size GetOutputSize (global::Com.Otaliastudios.Transcoder.Common.Size inputSize)
		{
			const string __id = "getOutputSize.(Lcom/otaliastudios/transcoder/common/Size;)Lcom/otaliastudios/transcoder/common/Size;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((inputSize == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inputSize).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.Size> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (inputSize);
			}
		}

	}
}
