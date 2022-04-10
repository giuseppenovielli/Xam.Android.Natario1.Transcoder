using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Internal.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.media']/class[@name='MediaFormatProvider']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/internal/media/MediaFormatProvider", DoNotGenerateAcw=true)]
	public partial class MediaFormatProvider : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/internal/media/MediaFormatProvider", typeof (MediaFormatProvider));

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

		protected MediaFormatProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.media']/class[@name='MediaFormatProvider']/constructor[@name='MediaFormatProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MediaFormatProvider () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_provideMediaFormat_Lcom_otaliastudios_transcoder_source_DataSource_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_;
#pragma warning disable 0169
		static Delegate GetProvideMediaFormat_Lcom_otaliastudios_transcoder_source_DataSource_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_Handler ()
		{
			if (cb_provideMediaFormat_Lcom_otaliastudios_transcoder_source_DataSource_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_ == null)
				cb_provideMediaFormat_Lcom_otaliastudios_transcoder_source_DataSource_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_ProvideMediaFormat_Lcom_otaliastudios_transcoder_source_DataSource_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_);
			return cb_provideMediaFormat_Lcom_otaliastudios_transcoder_source_DataSource_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_;
		}

		static IntPtr n_ProvideMediaFormat_Lcom_otaliastudios_transcoder_source_DataSource_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source, IntPtr native_type, IntPtr native_format)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Media.MediaFormatProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = (global::Com.Otaliastudios.Transcoder.Source.IDataSource)global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.IDataSource> (native_source, JniHandleOwnership.DoNotTransfer);
			var type = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (native_type, JniHandleOwnership.DoNotTransfer);
			var format = global::Java.Lang.Object.GetObject<global::Android.Media.MediaFormat> (native_format, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ProvideMediaFormat (source, type, format));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.media']/class[@name='MediaFormatProvider']/method[@name='provideMediaFormat' and count(parameter)=3 and parameter[1][@type='com.otaliastudios.transcoder.source.DataSource'] and parameter[2][@type='com.otaliastudios.transcoder.common.TrackType'] and parameter[3][@type='android.media.MediaFormat']]"
		[Register ("provideMediaFormat", "(Lcom/otaliastudios/transcoder/source/DataSource;Lcom/otaliastudios/transcoder/common/TrackType;Landroid/media/MediaFormat;)Landroid/media/MediaFormat;", "GetProvideMediaFormat_Lcom_otaliastudios_transcoder_source_DataSource_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_Handler")]
		public virtual unsafe global::Android.Media.MediaFormat ProvideMediaFormat (global::Com.Otaliastudios.Transcoder.Source.IDataSource source, global::Com.Otaliastudios.Transcoder.Common.TrackType type, global::Android.Media.MediaFormat format)
		{
			const string __id = "provideMediaFormat.(Lcom/otaliastudios/transcoder/source/DataSource;Lcom/otaliastudios/transcoder/common/TrackType;Landroid/media/MediaFormat;)Landroid/media/MediaFormat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				__args [1] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				__args [2] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Media.MediaFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (source);
				global::System.GC.KeepAlive (type);
				global::System.GC.KeepAlive (format);
			}
		}

	}
}
