using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Strategy {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/interface[@name='TrackStrategy']"
	[Register ("com/otaliastudios/transcoder/strategy/TrackStrategy", "", "Com.Otaliastudios.Transcoder.Strategy.ITrackStrategyInvoker")]
	public partial interface ITrackStrategy : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/interface[@name='TrackStrategy']/method[@name='createOutputFormat' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;android.media.MediaFormat&gt;'] and parameter[2][@type='android.media.MediaFormat']]"
		[Register ("createOutputFormat", "(Ljava/util/List;Landroid/media/MediaFormat;)Lcom/otaliastudios/transcoder/common/TrackStatus;", "GetCreateOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_Handler:Com.Otaliastudios.Transcoder.Strategy.ITrackStrategyInvoker, AndroidTranscoderBinding")]
		global::Com.Otaliastudios.Transcoder.Common.TrackStatus CreateOutputFormat (global::System.Collections.Generic.IList<global::Android.Media.MediaFormat> p0, global::Android.Media.MediaFormat p1);

	}

	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/strategy/TrackStrategy", DoNotGenerateAcw=true)]
	internal partial class ITrackStrategyInvoker : global::Java.Lang.Object, ITrackStrategy {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/strategy/TrackStrategy", typeof (ITrackStrategyInvoker));

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

		public static ITrackStrategy GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITrackStrategy> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.otaliastudios.transcoder.strategy.TrackStrategy'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITrackStrategyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_;
#pragma warning disable 0169
		static Delegate GetCreateOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_Handler ()
		{
			if (cb_createOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_ == null)
				cb_createOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_CreateOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_);
			return cb_createOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_;
		}

		static IntPtr n_CreateOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.ITrackStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Android.Media.MediaFormat>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaFormat> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateOutputFormat (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_;
		public unsafe global::Com.Otaliastudios.Transcoder.Common.TrackStatus CreateOutputFormat (global::System.Collections.Generic.IList<global::Android.Media.MediaFormat> p0, global::Android.Media.MediaFormat p1)
		{
			if (id_createOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_ == IntPtr.Zero)
				id_createOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_ = JNIEnv.GetMethodID (class_ref, "createOutputFormat", "(Ljava/util/List;Landroid/media/MediaFormat;)Lcom/otaliastudios/transcoder/common/TrackStatus;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Android.Media.MediaFormat>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
