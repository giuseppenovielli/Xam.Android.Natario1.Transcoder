using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Time {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.otaliastudios.transcoder.time']/interface[@name='TimeInterpolator']"
	[Register ("com/otaliastudios/transcoder/time/TimeInterpolator", "", "Com.Otaliastudios.Transcoder.Time.ITimeInterpolatorInvoker")]
	public partial interface ITimeInterpolator : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.time']/interface[@name='TimeInterpolator']/method[@name='interpolate' and count(parameter)=2 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackType'] and parameter[2][@type='long']]"
		[Register ("interpolate", "(Lcom/otaliastudios/transcoder/common/TrackType;J)J", "GetInterpolate_Lcom_otaliastudios_transcoder_common_TrackType_JHandler:Com.Otaliastudios.Transcoder.Time.ITimeInterpolatorInvoker, AndroidTranscoderBinding")]
		long Interpolate (global::Com.Otaliastudios.Transcoder.Common.TrackType p0, long p1);

	}

	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/time/TimeInterpolator", DoNotGenerateAcw=true)]
	internal partial class ITimeInterpolatorInvoker : global::Java.Lang.Object, ITimeInterpolator {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/time/TimeInterpolator", typeof (ITimeInterpolatorInvoker));

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

		public static ITimeInterpolator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITimeInterpolator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.otaliastudios.transcoder.time.TimeInterpolator'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITimeInterpolatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_interpolate_Lcom_otaliastudios_transcoder_common_TrackType_J;
#pragma warning disable 0169
		static Delegate GetInterpolate_Lcom_otaliastudios_transcoder_common_TrackType_JHandler ()
		{
			if (cb_interpolate_Lcom_otaliastudios_transcoder_common_TrackType_J == null)
				cb_interpolate_Lcom_otaliastudios_transcoder_common_TrackType_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_J) n_Interpolate_Lcom_otaliastudios_transcoder_common_TrackType_J);
			return cb_interpolate_Lcom_otaliastudios_transcoder_common_TrackType_J;
		}

		static long n_Interpolate_Lcom_otaliastudios_transcoder_common_TrackType_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Time.ITimeInterpolator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Interpolate (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_interpolate_Lcom_otaliastudios_transcoder_common_TrackType_J;
		public unsafe long Interpolate (global::Com.Otaliastudios.Transcoder.Common.TrackType p0, long p1)
		{
			if (id_interpolate_Lcom_otaliastudios_transcoder_common_TrackType_J == IntPtr.Zero)
				id_interpolate_Lcom_otaliastudios_transcoder_common_TrackType_J = JNIEnv.GetMethodID (class_ref, "interpolate", "(Lcom/otaliastudios/transcoder/common/TrackType;J)J");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			var __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_interpolate_Lcom_otaliastudios_transcoder_common_TrackType_J, __args);
			return __ret;
		}

	}
}
