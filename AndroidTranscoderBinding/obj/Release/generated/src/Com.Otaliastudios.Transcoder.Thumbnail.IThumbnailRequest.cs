using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Thumbnail {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.otaliastudios.transcoder.thumbnail']/interface[@name='ThumbnailRequest']"
	[Register ("com/otaliastudios/transcoder/thumbnail/ThumbnailRequest", "", "Com.Otaliastudios.Transcoder.Thumbnail.IThumbnailRequestInvoker")]
	public partial interface IThumbnailRequest : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.thumbnail']/interface[@name='ThumbnailRequest']/method[@name='locate' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("locate", "(J)Ljava/util/List;", "GetLocate_JHandler:Com.Otaliastudios.Transcoder.Thumbnail.IThumbnailRequestInvoker, AndroidTranscoderBinding")]
		global::System.Collections.Generic.IList<global::Java.Lang.Long> Locate (long durationUs);

	}

	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/thumbnail/ThumbnailRequest", DoNotGenerateAcw=true)]
	internal partial class IThumbnailRequestInvoker : global::Java.Lang.Object, IThumbnailRequest {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/thumbnail/ThumbnailRequest", typeof (IThumbnailRequestInvoker));

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

		public static IThumbnailRequest GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IThumbnailRequest> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.otaliastudios.transcoder.thumbnail.ThumbnailRequest'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IThumbnailRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_locate_J;
#pragma warning disable 0169
		static Delegate GetLocate_JHandler ()
		{
			if (cb_locate_J == null)
				cb_locate_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_L) n_Locate_J);
			return cb_locate_J;
		}

		static IntPtr n_Locate_J (IntPtr jnienv, IntPtr native__this, long durationUs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Thumbnail.IThumbnailRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.Long>.ToLocalJniHandle (__this.Locate (durationUs));
		}
#pragma warning restore 0169

		IntPtr id_locate_J;
		public unsafe global::System.Collections.Generic.IList<global::Java.Lang.Long> Locate (long durationUs)
		{
			if (id_locate_J == IntPtr.Zero)
				id_locate_J = JNIEnv.GetMethodID (class_ref, "locate", "(J)Ljava/util/List;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (durationUs);
			return global::Android.Runtime.JavaList<global::Java.Lang.Long>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_locate_J, __args), JniHandleOwnership.TransferLocalRef);
		}

	}
}
