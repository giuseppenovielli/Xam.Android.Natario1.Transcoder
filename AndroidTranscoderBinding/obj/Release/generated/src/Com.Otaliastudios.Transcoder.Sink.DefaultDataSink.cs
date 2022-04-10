using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Sink {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.sink']/class[@name='DefaultDataSink']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/sink/DefaultDataSink", DoNotGenerateAcw=true)]
	public partial class DefaultDataSink : global::Java.Lang.Object, global::Com.Otaliastudios.Transcoder.Sink.IDataSink {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/sink/DefaultDataSink", typeof (DefaultDataSink));

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

		protected DefaultDataSink (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.sink']/class[@name='DefaultDataSink']/constructor[@name='DefaultDataSink' and count(parameter)=1 and parameter[1][@type='java.io.FileDescriptor']]"
		[Register (".ctor", "(Ljava/io/FileDescriptor;)V", "")]
		public unsafe DefaultDataSink (global::Java.IO.FileDescriptor fileDescriptor) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/FileDescriptor;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fileDescriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fileDescriptor).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (fileDescriptor);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.sink']/class[@name='DefaultDataSink']/constructor[@name='DefaultDataSink' and count(parameter)=2 and parameter[1][@type='java.io.FileDescriptor'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/io/FileDescriptor;I)V", "")]
		public unsafe DefaultDataSink (global::Java.IO.FileDescriptor fileDescriptor, int format) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/FileDescriptor;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((fileDescriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fileDescriptor).Handle);
				__args [1] = new JniArgumentValue (format);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (fileDescriptor);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.sink']/class[@name='DefaultDataSink']/constructor[@name='DefaultDataSink' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe DefaultDataSink (string outputFilePath) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_outputFilePath = JNIEnv.NewString (outputFilePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_outputFilePath);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_outputFilePath);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.sink']/class[@name='DefaultDataSink']/constructor[@name='DefaultDataSink' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		public unsafe DefaultDataSink (string outputFilePath, int format) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_outputFilePath = JNIEnv.NewString (outputFilePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_outputFilePath);
				__args [1] = new JniArgumentValue (format);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_outputFilePath);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Sink.DefaultDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.sink']/class[@name='DefaultDataSink']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setLocation_DD;
#pragma warning disable 0169
		static Delegate GetSetLocation_DDHandler ()
		{
			if (cb_setLocation_DD == null)
				cb_setLocation_DD = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPDD_V) n_SetLocation_DD);
			return cb_setLocation_DD;
		}

		static void n_SetLocation_DD (IntPtr jnienv, IntPtr native__this, double latitude, double longitude)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Sink.DefaultDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLocation (latitude, longitude);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.sink']/class[@name='DefaultDataSink']/method[@name='setLocation' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("setLocation", "(DD)V", "GetSetLocation_DDHandler")]
		public virtual unsafe void SetLocation (double latitude, double longitude)
		{
			const string __id = "setLocation.(DD)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (latitude);
				__args [1] = new JniArgumentValue (longitude);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOrientation_I;
#pragma warning disable 0169
		static Delegate GetSetOrientation_IHandler ()
		{
			if (cb_setOrientation_I == null)
				cb_setOrientation_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetOrientation_I);
			return cb_setOrientation_I;
		}

		static void n_SetOrientation_I (IntPtr jnienv, IntPtr native__this, int rotation)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Sink.DefaultDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOrientation (rotation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.sink']/class[@name='DefaultDataSink']/method[@name='setOrientation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setOrientation", "(I)V", "GetSetOrientation_IHandler")]
		public virtual unsafe void SetOrientation (int rotation)
		{
			const string __id = "setOrientation.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rotation);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_;
#pragma warning disable 0169
		static Delegate GetSetTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_Handler ()
		{
			if (cb_setTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_ == null)
				cb_setTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_);
			return cb_setTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_;
		}

		static void n_SetTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type, IntPtr native_format)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Sink.DefaultDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var type = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (native_type, JniHandleOwnership.DoNotTransfer);
			var format = global::Java.Lang.Object.GetObject<global::Android.Media.MediaFormat> (native_format, JniHandleOwnership.DoNotTransfer);
			__this.SetTrackFormat (type, format);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.sink']/class[@name='DefaultDataSink']/method[@name='setTrackFormat' and count(parameter)=2 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackType'] and parameter[2][@type='android.media.MediaFormat']]"
		[Register ("setTrackFormat", "(Lcom/otaliastudios/transcoder/common/TrackType;Landroid/media/MediaFormat;)V", "GetSetTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_media_MediaFormat_Handler")]
		public virtual unsafe void SetTrackFormat (global::Com.Otaliastudios.Transcoder.Common.TrackType type, global::Android.Media.MediaFormat format)
		{
			const string __id = "setTrackFormat.(Lcom/otaliastudios/transcoder/common/TrackType;Landroid/media/MediaFormat;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				__args [1] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (type);
				global::System.GC.KeepAlive (format);
			}
		}

		static Delegate cb_setTrackStatus_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_common_TrackStatus_;
#pragma warning disable 0169
		static Delegate GetSetTrackStatus_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_common_TrackStatus_Handler ()
		{
			if (cb_setTrackStatus_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_common_TrackStatus_ == null)
				cb_setTrackStatus_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_common_TrackStatus_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetTrackStatus_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_common_TrackStatus_);
			return cb_setTrackStatus_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_common_TrackStatus_;
		}

		static void n_SetTrackStatus_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_common_TrackStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type, IntPtr native_status)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Sink.DefaultDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var type = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (native_type, JniHandleOwnership.DoNotTransfer);
			var status = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackStatus> (native_status, JniHandleOwnership.DoNotTransfer);
			__this.SetTrackStatus (type, status);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.sink']/class[@name='DefaultDataSink']/method[@name='setTrackStatus' and count(parameter)=2 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackType'] and parameter[2][@type='com.otaliastudios.transcoder.common.TrackStatus']]"
		[Register ("setTrackStatus", "(Lcom/otaliastudios/transcoder/common/TrackType;Lcom/otaliastudios/transcoder/common/TrackStatus;)V", "GetSetTrackStatus_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_common_TrackStatus_Handler")]
		public virtual unsafe void SetTrackStatus (global::Com.Otaliastudios.Transcoder.Common.TrackType type, global::Com.Otaliastudios.Transcoder.Common.TrackStatus status)
		{
			const string __id = "setTrackStatus.(Lcom/otaliastudios/transcoder/common/TrackType;Lcom/otaliastudios/transcoder/common/TrackStatus;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				__args [1] = new JniArgumentValue ((status == null) ? IntPtr.Zero : ((global::Java.Lang.Object) status).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (type);
				global::System.GC.KeepAlive (status);
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Sink.DefaultDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.sink']/class[@name='DefaultDataSink']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_writeTrack_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_;
#pragma warning disable 0169
		static Delegate GetWriteTrack_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_Handler ()
		{
			if (cb_writeTrack_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ == null)
				cb_writeTrack_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_WriteTrack_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_);
			return cb_writeTrack_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_;
		}

		static void n_WriteTrack_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type, IntPtr native_byteBuffer, IntPtr native_bufferInfo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Sink.DefaultDataSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var type = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (native_type, JniHandleOwnership.DoNotTransfer);
			var byteBuffer = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_byteBuffer, JniHandleOwnership.DoNotTransfer);
			var bufferInfo = global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodec.BufferInfo> (native_bufferInfo, JniHandleOwnership.DoNotTransfer);
			__this.WriteTrack (type, byteBuffer, bufferInfo);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.sink']/class[@name='DefaultDataSink']/method[@name='writeTrack' and count(parameter)=3 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackType'] and parameter[2][@type='java.nio.ByteBuffer'] and parameter[3][@type='android.media.MediaCodec.BufferInfo']]"
		[Register ("writeTrack", "(Lcom/otaliastudios/transcoder/common/TrackType;Ljava/nio/ByteBuffer;Landroid/media/MediaCodec$BufferInfo;)V", "GetWriteTrack_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_Handler")]
		public virtual unsafe void WriteTrack (global::Com.Otaliastudios.Transcoder.Common.TrackType type, global::Java.Nio.ByteBuffer byteBuffer, global::Android.Media.MediaCodec.BufferInfo bufferInfo)
		{
			const string __id = "writeTrack.(Lcom/otaliastudios/transcoder/common/TrackType;Ljava/nio/ByteBuffer;Landroid/media/MediaCodec$BufferInfo;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				__args [1] = new JniArgumentValue ((byteBuffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) byteBuffer).Handle);
				__args [2] = new JniArgumentValue ((bufferInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bufferInfo).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (type);
				global::System.GC.KeepAlive (byteBuffer);
				global::System.GC.KeepAlive (bufferInfo);
			}
		}

	}
}
