using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Validator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.validator']/class[@name='DefaultValidator']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/validator/DefaultValidator", DoNotGenerateAcw=true)]
	public partial class DefaultValidator : global::Java.Lang.Object, global::Com.Otaliastudios.Transcoder.Validator.IValidator {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/validator/DefaultValidator", typeof (DefaultValidator));

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

		protected DefaultValidator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.validator']/class[@name='DefaultValidator']/constructor[@name='DefaultValidator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultValidator () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_validate_Lcom_otaliastudios_transcoder_common_TrackStatus_Lcom_otaliastudios_transcoder_common_TrackStatus_;
#pragma warning disable 0169
		static Delegate GetValidate_Lcom_otaliastudios_transcoder_common_TrackStatus_Lcom_otaliastudios_transcoder_common_TrackStatus_Handler ()
		{
			if (cb_validate_Lcom_otaliastudios_transcoder_common_TrackStatus_Lcom_otaliastudios_transcoder_common_TrackStatus_ == null)
				cb_validate_Lcom_otaliastudios_transcoder_common_TrackStatus_Lcom_otaliastudios_transcoder_common_TrackStatus_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_Validate_Lcom_otaliastudios_transcoder_common_TrackStatus_Lcom_otaliastudios_transcoder_common_TrackStatus_);
			return cb_validate_Lcom_otaliastudios_transcoder_common_TrackStatus_Lcom_otaliastudios_transcoder_common_TrackStatus_;
		}

		static bool n_Validate_Lcom_otaliastudios_transcoder_common_TrackStatus_Lcom_otaliastudios_transcoder_common_TrackStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_videoStatus, IntPtr native_audioStatus)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Validator.DefaultValidator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var videoStatus = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackStatus> (native_videoStatus, JniHandleOwnership.DoNotTransfer);
			var audioStatus = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackStatus> (native_audioStatus, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Validate (videoStatus, audioStatus);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.validator']/class[@name='DefaultValidator']/method[@name='validate' and count(parameter)=2 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackStatus'] and parameter[2][@type='com.otaliastudios.transcoder.common.TrackStatus']]"
		[Register ("validate", "(Lcom/otaliastudios/transcoder/common/TrackStatus;Lcom/otaliastudios/transcoder/common/TrackStatus;)Z", "GetValidate_Lcom_otaliastudios_transcoder_common_TrackStatus_Lcom_otaliastudios_transcoder_common_TrackStatus_Handler")]
		public virtual unsafe bool Validate (global::Com.Otaliastudios.Transcoder.Common.TrackStatus videoStatus, global::Com.Otaliastudios.Transcoder.Common.TrackStatus audioStatus)
		{
			const string __id = "validate.(Lcom/otaliastudios/transcoder/common/TrackStatus;Lcom/otaliastudios/transcoder/common/TrackStatus;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((videoStatus == null) ? IntPtr.Zero : ((global::Java.Lang.Object) videoStatus).Handle);
				__args [1] = new JniArgumentValue ((audioStatus == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioStatus).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (videoStatus);
				global::System.GC.KeepAlive (audioStatus);
			}
		}

	}
}
