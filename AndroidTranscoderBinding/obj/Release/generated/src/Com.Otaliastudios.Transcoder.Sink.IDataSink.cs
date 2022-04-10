using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Sink {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.otaliastudios.transcoder.sink']/interface[@name='DataSink']"
	[Register ("com/otaliastudios/transcoder/sink/DataSink", "", "Com.Otaliastudios.Transcoder.Sink.IDataSinkInvoker")]
	public partial interface IDataSink : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.sink']/interface[@name='DataSink']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler:Com.Otaliastudios.Transcoder.Sink.IDataSinkInvoker, AndroidTranscoderBinding")]
		void Release ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.sink']/interface[@name='DataSink']/method[@name='setLocation' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("setLocation", "(DD)V", "GetSetLocation_DDHandler:Com.Otaliastudios.Transcoder.Sink.IDataSinkInvoker, AndroidTranscoderBinding")]
		void SetLocation (double p0, double p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.sink']/interface[@name='DataSink']/method[@name='setOrientation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setOrientation", "(I)V", "GetSetOrientation_IHandler:Com.Otaliastudios.Transcoder.Sink.IDataSinkInvoker, AndroidTranscoderBinding")]
		void SetOrientation (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.sink']/interface[@name='DataSink']/method[@name='setTrackFormat' and count(parameter)=2 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackType'] and parameter[2][@type='android.media.MediaFormat']]"
		[Register ("setTrackFormat", "(Lcom/otaliastudios/transcoder/common/TrackType;Landroid/media/MediaFormat;)V", "GetSetTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_Handler:Com.Otaliastudios.Transcoder.Sink.IDataSinkInvoker, AndroidTranscoderBinding")]
		void SetTrackFormat (global::Com.Otaliastudios.Transcoder.Common.TrackType p0, global::Android.Media.MediaFormat p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.sink']/interface[@name='DataSink']/method[@name='setTrackStatus' and count(parameter)=2 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackType'] and parameter[2][@type='com.otaliastudios.transcoder.common.TrackStatus']]"
		[Register ("setTrackStatus", "(Lcom/otaliastudios/transcoder/common/TrackType;Lcom/otaliastudios/transcoder/common/TrackStatus;)V", "GetSetTrackStatus_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_common_TrackStatus_Handler:Com.Otaliastudios.Transcoder.Sink.IDataSinkInvoker, AndroidTranscoderBinding")]
		void SetTrackStatus (global::Com.Otaliastudios.Transcoder.Common.TrackType p0, global::Com.Otaliastudios.Transcoder.Common.TrackStatus p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.sink']/interface[@name='DataSink']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler:Com.Otaliastudios.Transcoder.Sink.IDataSinkInvoker, AndroidTranscoderBinding")]
		void Stop ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.sink']/interface[@name='DataSink']/method[@name='writeTrack' and count(parameter)=3 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackType'] and parameter[2][@type='java.nio.ByteBuffer'] and parameter[3][@type='android.media.MediaCodec.BufferInfo']]"
		[Register ("writeTrack", "(Lcom/otaliastudios/transcoder/common/TrackType;Ljava/nio/ByteBuffer;Landroid/media/MediaCodec$BufferInfo;)V", "GetWriteTrack_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_Handler:Com.Otaliastudios.Transcoder.Sink.IDataSinkInvoker, AndroidTranscoderBinding")]
		void WriteTrack (global::Com.Otaliastudios.Transcoder.Common.TrackType p0, global::Java.Nio.ByteBuffer p1, global::Android.Media.MediaCodec.BufferInfo p2);

	}

	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/sink/DataSink", DoNotGenerateAcw=true)]
	internal partial class IDataSinkInvoker : global::Java.Lang.Object, IDataSink {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/sink/DataSink", typeof (IDataSinkInvoker));

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

		public static IDataSink GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDataSink> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.otaliastudios.transcoder.sink.DataSink'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDataSinkInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Sink.IDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		IntPtr id_release;
		public unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
		}

		static Delegate cb_setLocation_DD;
#pragma warning disable 0169
		static Delegate GetSetLocation_DDHandler ()
		{
			if (cb_setLocation_DD == null)
				cb_setLocation_DD = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPDD_V) n_SetLocation_DD);
			return cb_setLocation_DD;
		}

		static void n_SetLocation_DD (IntPtr jnienv, IntPtr native__this, double p0, double p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Sink.IDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLocation (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setLocation_DD;
		public unsafe void SetLocation (double p0, double p1)
		{
			if (id_setLocation_DD == IntPtr.Zero)
				id_setLocation_DD = JNIEnv.GetMethodID (class_ref, "setLocation", "(DD)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLocation_DD, __args);
		}

		static Delegate cb_setOrientation_I;
#pragma warning disable 0169
		static Delegate GetSetOrientation_IHandler ()
		{
			if (cb_setOrientation_I == null)
				cb_setOrientation_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetOrientation_I);
			return cb_setOrientation_I;
		}

		static void n_SetOrientation_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Sink.IDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOrientation (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOrientation_I;
		public unsafe void SetOrientation (int p0)
		{
			if (id_setOrientation_I == IntPtr.Zero)
				id_setOrientation_I = JNIEnv.GetMethodID (class_ref, "setOrientation", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOrientation_I, __args);
		}

		static Delegate cb_setTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_;
#pragma warning disable 0169
		static Delegate GetSetTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_Handler ()
		{
			if (cb_setTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_ == null)
				cb_setTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_);
			return cb_setTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_;
		}

		static void n_SetTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Sink.IDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaFormat> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetTrackFormat (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_;
		public unsafe void SetTrackFormat (global::Com.Otaliastudios.Transcoder.Common.TrackType p0, global::Android.Media.MediaFormat p1)
		{
			if (id_setTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_ == IntPtr.Zero)
				id_setTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_ = JNIEnv.GetMethodID (class_ref, "setTrackFormat", "(Lcom/otaliastudios/transcoder/common/TrackType;Landroid/media/MediaFormat;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_, __args);
		}

		static Delegate cb_setTrackStatus_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_common_TrackStatus_;
#pragma warning disable 0169
		static Delegate GetSetTrackStatus_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_common_TrackStatus_Handler ()
		{
			if (cb_setTrackStatus_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_common_TrackStatus_ == null)
				cb_setTrackStatus_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_common_TrackStatus_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetTrackStatus_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_common_TrackStatus_);
			return cb_setTrackStatus_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_common_TrackStatus_;
		}

		static void n_SetTrackStatus_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_common_TrackStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Sink.IDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackStatus> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetTrackStatus (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setTrackStatus_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_common_TrackStatus_;
		public unsafe void SetTrackStatus (global::Com.Otaliastudios.Transcoder.Common.TrackType p0, global::Com.Otaliastudios.Transcoder.Common.TrackStatus p1)
		{
			if (id_setTrackStatus_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_common_TrackStatus_ == IntPtr.Zero)
				id_setTrackStatus_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_common_TrackStatus_ = JNIEnv.GetMethodID (class_ref, "setTrackStatus", "(Lcom/otaliastudios/transcoder/common/TrackType;Lcom/otaliastudios/transcoder/common/TrackStatus;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrackStatus_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_common_TrackStatus_, __args);
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Sink.IDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		IntPtr id_stop;
		public unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
		}

		static Delegate cb_writeTrack_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_;
#pragma warning disable 0169
		static Delegate GetWriteTrack_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_Handler ()
		{
			if (cb_writeTrack_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ == null)
				cb_writeTrack_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_WriteTrack_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_);
			return cb_writeTrack_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_;
		}

		static void n_WriteTrack_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Sink.IDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodec.BufferInfo> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.WriteTrack (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_writeTrack_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_;
		public unsafe void WriteTrack (global::Com.Otaliastudios.Transcoder.Common.TrackType p0, global::Java.Nio.ByteBuffer p1, global::Android.Media.MediaCodec.BufferInfo p2)
		{
			if (id_writeTrack_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ == IntPtr.Zero)
				id_writeTrack_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ = JNIEnv.GetMethodID (class_ref, "writeTrack", "(Lcom/otaliastudios/transcoder/common/TrackType;Ljava/nio/ByteBuffer;Landroid/media/MediaCodec$BufferInfo;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeTrack_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_, __args);
		}

	}
}
