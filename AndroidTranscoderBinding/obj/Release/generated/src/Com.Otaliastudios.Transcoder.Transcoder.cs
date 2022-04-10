using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='Transcoder']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/Transcoder", DoNotGenerateAcw=true)]
	public partial class Transcoder : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='Transcoder']/field[@name='SUCCESS_NOT_NEEDED']"
		[Register ("SUCCESS_NOT_NEEDED")]
		public const int SuccessNotNeeded = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='Transcoder']/field[@name='SUCCESS_TRANSCODED']"
		[Register ("SUCCESS_TRANSCODED")]
		public const int SuccessTranscoded = (int) 0;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/Transcoder", typeof (Transcoder));

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

		protected Transcoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public static unsafe global::Com.Otaliastudios.Transcoder.Transcoder Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='Transcoder']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/otaliastudios/transcoder/Transcoder;", "")]
			get {
				const string __id = "getInstance.()Lcom/otaliastudios/transcoder/Transcoder;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Transcoder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='Transcoder']/method[@name='into' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.sink.DataSink']]"
		[Register ("into", "(Lcom/otaliastudios/transcoder/sink/DataSink;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;", "")]
		public static unsafe global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder Into (global::Com.Otaliastudios.Transcoder.Sink.IDataSink dataSink)
		{
			const string __id = "into.(Lcom/otaliastudios/transcoder/sink/DataSink;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dataSink == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSink).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (dataSink);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='Transcoder']/method[@name='into' and count(parameter)=1 and parameter[1][@type='java.io.FileDescriptor']]"
		[Register ("into", "(Ljava/io/FileDescriptor;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;", "")]
		public static unsafe global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder Into (global::Java.IO.FileDescriptor fileDescriptor)
		{
			const string __id = "into.(Ljava/io/FileDescriptor;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fileDescriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fileDescriptor).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (fileDescriptor);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='Transcoder']/method[@name='into' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("into", "(Ljava/lang/String;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;", "")]
		public static unsafe global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder Into (string outPath)
		{
			const string __id = "into.(Ljava/lang/String;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;";
			IntPtr native_outPath = JNIEnv.NewString (outPath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_outPath);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_outPath);
			}
		}

		static Delegate cb_transcode_Lcom_otaliastudios_transcoder_TranscoderOptions_;
#pragma warning disable 0169
		static Delegate GetTranscode_Lcom_otaliastudios_transcoder_TranscoderOptions_Handler ()
		{
			if (cb_transcode_Lcom_otaliastudios_transcoder_TranscoderOptions_ == null)
				cb_transcode_Lcom_otaliastudios_transcoder_TranscoderOptions_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Transcode_Lcom_otaliastudios_transcoder_TranscoderOptions_);
			return cb_transcode_Lcom_otaliastudios_transcoder_TranscoderOptions_;
		}

		static IntPtr n_Transcode_Lcom_otaliastudios_transcoder_TranscoderOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Transcoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var options = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Transcode (options));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='Transcoder']/method[@name='transcode' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.TranscoderOptions']]"
		[Register ("transcode", "(Lcom/otaliastudios/transcoder/TranscoderOptions;)Ljava/util/concurrent/Future;", "GetTranscode_Lcom_otaliastudios_transcoder_TranscoderOptions_Handler")]
		public virtual unsafe global::Java.Util.Concurrent.IFuture Transcode (global::Com.Otaliastudios.Transcoder.TranscoderOptions options)
		{
			const string __id = "transcode.(Lcom/otaliastudios/transcoder/TranscoderOptions;)Ljava/util/concurrent/Future;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (options);
			}
		}

	}
}
