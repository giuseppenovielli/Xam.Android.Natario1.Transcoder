using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Validator {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.otaliastudios.transcoder.validator']/interface[@name='Validator']"
	[Register ("com/otaliastudios/transcoder/validator/Validator", "", "Com.Otaliastudios.Transcoder.Validator.IValidatorInvoker")]
	public partial interface IValidator : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.validator']/interface[@name='Validator']/method[@name='validate' and count(parameter)=2 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackStatus'] and parameter[2][@type='com.otaliastudios.transcoder.common.TrackStatus']]"
		[Register ("validate", "(Lcom/otaliastudios/transcoder/common/TrackStatus;Lcom/otaliastudios/transcoder/common/TrackStatus;)Z", "GetValidate_Lcom_otaliastudios_transcoder_common_TrackStatus_Lcom_otaliastudios_transcoder_common_TrackStatus_Handler:Com.Otaliastudios.Transcoder.Validator.IValidatorInvoker, AndroidTranscoderBinding")]
		bool Validate (global::Com.Otaliastudios.Transcoder.Common.TrackStatus p0, global::Com.Otaliastudios.Transcoder.Common.TrackStatus p1);

	}

	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/validator/Validator", DoNotGenerateAcw=true)]
	internal partial class IValidatorInvoker : global::Java.Lang.Object, IValidator {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/validator/Validator", typeof (IValidatorInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IValidator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IValidator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.otaliastudios.transcoder.validator.Validator'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IValidatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_validate_Lcom_otaliastudios_transcoder_common_TrackStatus_Lcom_otaliastudios_transcoder_common_TrackStatus_;
#pragma warning disable 0169
		static Delegate GetValidate_Lcom_otaliastudios_transcoder_common_TrackStatus_Lcom_otaliastudios_transcoder_common_TrackStatus_Handler ()
		{
			if (cb_validate_Lcom_otaliastudios_transcoder_common_TrackStatus_Lcom_otaliastudios_transcoder_common_TrackStatus_ == null)
				cb_validate_Lcom_otaliastudios_transcoder_common_TrackStatus_Lcom_otaliastudios_transcoder_common_TrackStatus_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_Validate_Lcom_otaliastudios_transcoder_common_TrackStatus_Lcom_otaliastudios_transcoder_common_TrackStatus_);
			return cb_validate_Lcom_otaliastudios_transcoder_common_TrackStatus_Lcom_otaliastudios_transcoder_common_TrackStatus_;
		}

		static bool n_Validate_Lcom_otaliastudios_transcoder_common_TrackStatus_Lcom_otaliastudios_transcoder_common_TrackStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Validator.IValidator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackStatus> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Validate (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_validate_Lcom_otaliastudios_transcoder_common_TrackStatus_Lcom_otaliastudios_transcoder_common_TrackStatus_;
		public unsafe bool Validate (global::Com.Otaliastudios.Transcoder.Common.TrackStatus p0, global::Com.Otaliastudios.Transcoder.Common.TrackStatus p1)
		{
			if (id_validate_Lcom_otaliastudios_transcoder_common_TrackStatus_Lcom_otaliastudios_transcoder_common_TrackStatus_ == IntPtr.Zero)
				id_validate_Lcom_otaliastudios_transcoder_common_TrackStatus_Lcom_otaliastudios_transcoder_common_TrackStatus_ = JNIEnv.GetMethodID (class_ref, "validate", "(Lcom/otaliastudios/transcoder/common/TrackStatus;Lcom/otaliastudios/transcoder/common/TrackStatus;)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_validate_Lcom_otaliastudios_transcoder_common_TrackStatus_Lcom_otaliastudios_transcoder_common_TrackStatus_, __args);
			return __ret;
		}

	}
}
