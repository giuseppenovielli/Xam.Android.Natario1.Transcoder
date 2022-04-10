using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Time {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.time']/class[@name='DefaultTimeInterpolator']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/time/DefaultTimeInterpolator", DoNotGenerateAcw=true)]
	public partial class DefaultTimeInterpolator : global::Java.Lang.Object, global::Com.Otaliastudios.Transcoder.Time.ITimeInterpolator {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/time/DefaultTimeInterpolator", typeof (DefaultTimeInterpolator));

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

		protected DefaultTimeInterpolator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.time']/class[@name='DefaultTimeInterpolator']/constructor[@name='DefaultTimeInterpolator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultTimeInterpolator () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_interpolate_Lcom_otaliastudios_transcoder_common_TrackType_J;
#pragma warning disable 0169
		static Delegate GetInterpolate_Lcom_otaliastudios_transcoder_common_TrackType_JHandler ()
		{
			if (cb_interpolate_Lcom_otaliastudios_transcoder_common_TrackType_J == null)
				cb_interpolate_Lcom_otaliastudios_transcoder_common_TrackType_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_J) n_Interpolate_Lcom_otaliastudios_transcoder_common_TrackType_J);
			return cb_interpolate_Lcom_otaliastudios_transcoder_common_TrackType_J;
		}

		static long n_Interpolate_Lcom_otaliastudios_transcoder_common_TrackType_J (IntPtr jnienv, IntPtr native__this, IntPtr native_type, long time)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Time.DefaultTimeInterpolator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var type = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (native_type, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Interpolate (type, time);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.time']/class[@name='DefaultTimeInterpolator']/method[@name='interpolate' and count(parameter)=2 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackType'] and parameter[2][@type='long']]"
		[Register ("interpolate", "(Lcom/otaliastudios/transcoder/common/TrackType;J)J", "GetInterpolate_Lcom_otaliastudios_transcoder_common_TrackType_JHandler")]
		public virtual unsafe long Interpolate (global::Com.Otaliastudios.Transcoder.Common.TrackType type, long time)
		{
			const string __id = "interpolate.(Lcom/otaliastudios/transcoder/common/TrackType;J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				__args [1] = new JniArgumentValue (time);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (type);
			}
		}

	}
}
