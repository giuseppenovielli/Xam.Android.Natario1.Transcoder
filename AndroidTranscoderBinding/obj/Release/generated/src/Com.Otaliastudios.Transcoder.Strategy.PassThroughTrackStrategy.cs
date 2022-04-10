using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Strategy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='PassThroughTrackStrategy']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/strategy/PassThroughTrackStrategy", DoNotGenerateAcw=true)]
	public partial class PassThroughTrackStrategy : global::Java.Lang.Object, global::Com.Otaliastudios.Transcoder.Strategy.ITrackStrategy {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/strategy/PassThroughTrackStrategy", typeof (PassThroughTrackStrategy));

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

		protected PassThroughTrackStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='PassThroughTrackStrategy']/constructor[@name='PassThroughTrackStrategy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PassThroughTrackStrategy () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_createOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_;
#pragma warning disable 0169
		static Delegate GetCreateOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_Handler ()
		{
			if (cb_createOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_ == null)
				cb_createOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_CreateOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_);
			return cb_createOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_;
		}

		static IntPtr n_CreateOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inputFormats, IntPtr native_outputFormat)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.PassThroughTrackStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var inputFormats = global::Android.Runtime.JavaList<global::Android.Media.MediaFormat>.FromJniHandle (native_inputFormats, JniHandleOwnership.DoNotTransfer);
			var outputFormat = global::Java.Lang.Object.GetObject<global::Android.Media.MediaFormat> (native_outputFormat, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateOutputFormat (inputFormats, outputFormat));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.strategy']/class[@name='PassThroughTrackStrategy']/method[@name='createOutputFormat' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;android.media.MediaFormat&gt;'] and parameter[2][@type='android.media.MediaFormat']]"
		[Register ("createOutputFormat", "(Ljava/util/List;Landroid/media/MediaFormat;)Lcom/otaliastudios/transcoder/common/TrackStatus;", "GetCreateOutputFormat_Ljava_util_List_Landroid_media_MediaFormat_Handler")]
		public virtual unsafe global::Com.Otaliastudios.Transcoder.Common.TrackStatus CreateOutputFormat (global::System.Collections.Generic.IList<global::Android.Media.MediaFormat> inputFormats, global::Android.Media.MediaFormat outputFormat)
		{
			const string __id = "createOutputFormat.(Ljava/util/List;Landroid/media/MediaFormat;)Lcom/otaliastudios/transcoder/common/TrackStatus;";
			IntPtr native_inputFormats = global::Android.Runtime.JavaList<global::Android.Media.MediaFormat>.ToLocalJniHandle (inputFormats);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_inputFormats);
				__args [1] = new JniArgumentValue ((outputFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputFormat).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_inputFormats);
				global::System.GC.KeepAlive (inputFormats);
				global::System.GC.KeepAlive (outputFormat);
			}
		}

	}
}
