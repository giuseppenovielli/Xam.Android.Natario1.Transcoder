using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Resize {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.otaliastudios.transcoder.resize']/interface[@name='Resizer']"
	[Register ("com/otaliastudios/transcoder/resize/Resizer", "", "Com.Otaliastudios.Transcoder.Resize.IResizerInvoker")]
	public partial interface IResizer : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.resize']/interface[@name='Resizer']/method[@name='getOutputSize' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.common.Size']]"
		[Register ("getOutputSize", "(Lcom/otaliastudios/transcoder/common/Size;)Lcom/otaliastudios/transcoder/common/Size;", "GetGetOutputSize_Lcom_otaliastudios_transcoder_common_Size_Handler:Com.Otaliastudios.Transcoder.Resize.IResizerInvoker, AndroidTranscoderBinding")]
		global::Com.Otaliastudios.Transcoder.Common.Size GetOutputSize (global::Com.Otaliastudios.Transcoder.Common.Size p0);

	}

	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/resize/Resizer", DoNotGenerateAcw=true)]
	internal partial class IResizerInvoker : global::Java.Lang.Object, IResizer {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/resize/Resizer", typeof (IResizerInvoker));

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

		public static IResizer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResizer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.otaliastudios.transcoder.resize.Resizer'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResizerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getOutputSize_Lcom_otaliastudios_transcoder_common_Size_;
#pragma warning disable 0169
		static Delegate GetGetOutputSize_Lcom_otaliastudios_transcoder_common_Size_Handler ()
		{
			if (cb_getOutputSize_Lcom_otaliastudios_transcoder_common_Size_ == null)
				cb_getOutputSize_Lcom_otaliastudios_transcoder_common_Size_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetOutputSize_Lcom_otaliastudios_transcoder_common_Size_);
			return cb_getOutputSize_Lcom_otaliastudios_transcoder_common_Size_;
		}

		static IntPtr n_GetOutputSize_Lcom_otaliastudios_transcoder_common_Size_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Resize.IResizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.Size> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetOutputSize (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getOutputSize_Lcom_otaliastudios_transcoder_common_Size_;
		public unsafe global::Com.Otaliastudios.Transcoder.Common.Size GetOutputSize (global::Com.Otaliastudios.Transcoder.Common.Size p0)
		{
			if (id_getOutputSize_Lcom_otaliastudios_transcoder_common_Size_ == IntPtr.Zero)
				id_getOutputSize_Lcom_otaliastudios_transcoder_common_Size_ = JNIEnv.GetMethodID (class_ref, "getOutputSize", "(Lcom/otaliastudios/transcoder/common/Size;)Lcom/otaliastudios/transcoder/common/Size;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.Size> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOutputSize_Lcom_otaliastudios_transcoder_common_Size_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
