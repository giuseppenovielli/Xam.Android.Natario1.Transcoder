using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/TranscoderOptions", DoNotGenerateAcw=true)]
	public partial class TranscoderOptions : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions.Builder']"
		[global::Android.Runtime.Register ("com/otaliastudios/transcoder/TranscoderOptions$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/TranscoderOptions$Builder", typeof (Builder));

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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			static Delegate cb_addDataSource_Landroid_content_Context_Landroid_net_Uri_;
#pragma warning disable 0169
			static Delegate GetAddDataSource_Landroid_content_Context_Landroid_net_Uri_Handler ()
			{
				if (cb_addDataSource_Landroid_content_Context_Landroid_net_Uri_ == null)
					cb_addDataSource_Landroid_content_Context_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddDataSource_Landroid_content_Context_Landroid_net_Uri_);
				return cb_addDataSource_Landroid_content_Context_Landroid_net_Uri_;
			}

			static IntPtr n_AddDataSource_Landroid_content_Context_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_uri)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
				var uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddDataSource (context, uri));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions.Builder']/method[@name='addDataSource' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
			[Register ("addDataSource", "(Landroid/content/Context;Landroid/net/Uri;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;", "GetAddDataSource_Landroid_content_Context_Landroid_net_Uri_Handler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder AddDataSource (global::Android.Content.Context context, global::Android.Net.Uri uri)
			{
				const string __id = "addDataSource.(Landroid/content/Context;Landroid/net/Uri;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (context);
					global::System.GC.KeepAlive (uri);
				}
			}

			static Delegate cb_addDataSource_Landroid_content_res_AssetFileDescriptor_;
#pragma warning disable 0169
			static Delegate GetAddDataSource_Landroid_content_res_AssetFileDescriptor_Handler ()
			{
				if (cb_addDataSource_Landroid_content_res_AssetFileDescriptor_ == null)
					cb_addDataSource_Landroid_content_res_AssetFileDescriptor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddDataSource_Landroid_content_res_AssetFileDescriptor_);
				return cb_addDataSource_Landroid_content_res_AssetFileDescriptor_;
			}

			static IntPtr n_AddDataSource_Landroid_content_res_AssetFileDescriptor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_assetFileDescriptor)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var assetFileDescriptor = global::Java.Lang.Object.GetObject<global::Android.Content.Res.AssetFileDescriptor> (native_assetFileDescriptor, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddDataSource (assetFileDescriptor));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions.Builder']/method[@name='addDataSource' and count(parameter)=1 and parameter[1][@type='android.content.res.AssetFileDescriptor']]"
			[Register ("addDataSource", "(Landroid/content/res/AssetFileDescriptor;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;", "GetAddDataSource_Landroid_content_res_AssetFileDescriptor_Handler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder AddDataSource (global::Android.Content.Res.AssetFileDescriptor assetFileDescriptor)
			{
				const string __id = "addDataSource.(Landroid/content/res/AssetFileDescriptor;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((assetFileDescriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) assetFileDescriptor).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (assetFileDescriptor);
				}
			}

			static Delegate cb_addDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_content_Context_Landroid_net_Uri_;
#pragma warning disable 0169
			static Delegate GetAddDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_content_Context_Landroid_net_Uri_Handler ()
			{
				if (cb_addDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_content_Context_Landroid_net_Uri_ == null)
					cb_addDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_content_Context_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_AddDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_content_Context_Landroid_net_Uri_);
				return cb_addDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_content_Context_Landroid_net_Uri_;
			}

			static IntPtr n_AddDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_content_Context_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type, IntPtr native_context, IntPtr native_uri)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var type = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (native_type, JniHandleOwnership.DoNotTransfer);
				var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
				var uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddDataSource (type, context, uri));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions.Builder']/method[@name='addDataSource' and count(parameter)=3 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackType'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='android.net.Uri']]"
			[Register ("addDataSource", "(Lcom/otaliastudios/transcoder/common/TrackType;Landroid/content/Context;Landroid/net/Uri;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;", "GetAddDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_content_Context_Landroid_net_Uri_Handler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder AddDataSource (global::Com.Otaliastudios.Transcoder.Common.TrackType type, global::Android.Content.Context context, global::Android.Net.Uri uri)
			{
				const string __id = "addDataSource.(Lcom/otaliastudios/transcoder/common/TrackType;Landroid/content/Context;Landroid/net/Uri;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					__args [2] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (type);
					global::System.GC.KeepAlive (context);
					global::System.GC.KeepAlive (uri);
				}
			}

			static Delegate cb_addDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_content_res_AssetFileDescriptor_;
#pragma warning disable 0169
			static Delegate GetAddDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_content_res_AssetFileDescriptor_Handler ()
			{
				if (cb_addDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_content_res_AssetFileDescriptor_ == null)
					cb_addDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_content_res_AssetFileDescriptor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_content_res_AssetFileDescriptor_);
				return cb_addDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_content_res_AssetFileDescriptor_;
			}

			static IntPtr n_AddDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_content_res_AssetFileDescriptor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type, IntPtr native_assetFileDescriptor)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var type = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (native_type, JniHandleOwnership.DoNotTransfer);
				var assetFileDescriptor = global::Java.Lang.Object.GetObject<global::Android.Content.Res.AssetFileDescriptor> (native_assetFileDescriptor, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddDataSource (type, assetFileDescriptor));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions.Builder']/method[@name='addDataSource' and count(parameter)=2 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackType'] and parameter[2][@type='android.content.res.AssetFileDescriptor']]"
			[Register ("addDataSource", "(Lcom/otaliastudios/transcoder/common/TrackType;Landroid/content/res/AssetFileDescriptor;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;", "GetAddDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Landroid_content_res_AssetFileDescriptor_Handler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder AddDataSource (global::Com.Otaliastudios.Transcoder.Common.TrackType type, global::Android.Content.Res.AssetFileDescriptor assetFileDescriptor)
			{
				const string __id = "addDataSource.(Lcom/otaliastudios/transcoder/common/TrackType;Landroid/content/res/AssetFileDescriptor;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					__args [1] = new JniArgumentValue ((assetFileDescriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) assetFileDescriptor).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (type);
					global::System.GC.KeepAlive (assetFileDescriptor);
				}
			}

			static Delegate cb_addDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_source_DataSource_;
#pragma warning disable 0169
			static Delegate GetAddDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_source_DataSource_Handler ()
			{
				if (cb_addDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_source_DataSource_ == null)
					cb_addDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_source_DataSource_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_source_DataSource_);
				return cb_addDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_source_DataSource_;
			}

			static IntPtr n_AddDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_source_DataSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type, IntPtr native_dataSource)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var type = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (native_type, JniHandleOwnership.DoNotTransfer);
				var dataSource = (global::Com.Otaliastudios.Transcoder.Source.IDataSource)global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.IDataSource> (native_dataSource, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddDataSource (type, dataSource));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions.Builder']/method[@name='addDataSource' and count(parameter)=2 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackType'] and parameter[2][@type='com.otaliastudios.transcoder.source.DataSource']]"
			[Register ("addDataSource", "(Lcom/otaliastudios/transcoder/common/TrackType;Lcom/otaliastudios/transcoder/source/DataSource;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;", "GetAddDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Lcom_otaliastudios_transcoder_source_DataSource_Handler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder AddDataSource (global::Com.Otaliastudios.Transcoder.Common.TrackType type, global::Com.Otaliastudios.Transcoder.Source.IDataSource dataSource)
			{
				const string __id = "addDataSource.(Lcom/otaliastudios/transcoder/common/TrackType;Lcom/otaliastudios/transcoder/source/DataSource;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					__args [1] = new JniArgumentValue ((dataSource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSource).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (type);
					global::System.GC.KeepAlive (dataSource);
				}
			}

			static Delegate cb_addDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_io_FileDescriptor_;
#pragma warning disable 0169
			static Delegate GetAddDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_io_FileDescriptor_Handler ()
			{
				if (cb_addDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_io_FileDescriptor_ == null)
					cb_addDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_io_FileDescriptor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_io_FileDescriptor_);
				return cb_addDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_io_FileDescriptor_;
			}

			static IntPtr n_AddDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_io_FileDescriptor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type, IntPtr native_fileDescriptor)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var type = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (native_type, JniHandleOwnership.DoNotTransfer);
				var fileDescriptor = global::Java.Lang.Object.GetObject<global::Java.IO.FileDescriptor> (native_fileDescriptor, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddDataSource (type, fileDescriptor));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions.Builder']/method[@name='addDataSource' and count(parameter)=2 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackType'] and parameter[2][@type='java.io.FileDescriptor']]"
			[Register ("addDataSource", "(Lcom/otaliastudios/transcoder/common/TrackType;Ljava/io/FileDescriptor;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;", "GetAddDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_io_FileDescriptor_Handler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder AddDataSource (global::Com.Otaliastudios.Transcoder.Common.TrackType type, global::Java.IO.FileDescriptor fileDescriptor)
			{
				const string __id = "addDataSource.(Lcom/otaliastudios/transcoder/common/TrackType;Ljava/io/FileDescriptor;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					__args [1] = new JniArgumentValue ((fileDescriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fileDescriptor).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (type);
					global::System.GC.KeepAlive (fileDescriptor);
				}
			}

			static Delegate cb_addDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAddDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_lang_String_Handler ()
			{
				if (cb_addDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_lang_String_ == null)
					cb_addDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_lang_String_);
				return cb_addDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_lang_String_;
			}

			static IntPtr n_AddDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type, IntPtr native_inPath)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var type = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (native_type, JniHandleOwnership.DoNotTransfer);
				var inPath = JNIEnv.GetString (native_inPath, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddDataSource (type, inPath));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions.Builder']/method[@name='addDataSource' and count(parameter)=2 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackType'] and parameter[2][@type='java.lang.String']]"
			[Register ("addDataSource", "(Lcom/otaliastudios/transcoder/common/TrackType;Ljava/lang/String;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;", "GetAddDataSource_Lcom_otaliastudios_transcoder_common_TrackType_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder AddDataSource (global::Com.Otaliastudios.Transcoder.Common.TrackType type, string inPath)
			{
				const string __id = "addDataSource.(Lcom/otaliastudios/transcoder/common/TrackType;Ljava/lang/String;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;";
				IntPtr native_inPath = JNIEnv.NewString (inPath);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					__args [1] = new JniArgumentValue (native_inPath);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_inPath);
					global::System.GC.KeepAlive (type);
				}
			}

			static Delegate cb_addDataSource_Lcom_otaliastudios_transcoder_source_DataSource_;
#pragma warning disable 0169
			static Delegate GetAddDataSource_Lcom_otaliastudios_transcoder_source_DataSource_Handler ()
			{
				if (cb_addDataSource_Lcom_otaliastudios_transcoder_source_DataSource_ == null)
					cb_addDataSource_Lcom_otaliastudios_transcoder_source_DataSource_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddDataSource_Lcom_otaliastudios_transcoder_source_DataSource_);
				return cb_addDataSource_Lcom_otaliastudios_transcoder_source_DataSource_;
			}

			static IntPtr n_AddDataSource_Lcom_otaliastudios_transcoder_source_DataSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dataSource)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var dataSource = (global::Com.Otaliastudios.Transcoder.Source.IDataSource)global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.IDataSource> (native_dataSource, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddDataSource (dataSource));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions.Builder']/method[@name='addDataSource' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.source.DataSource']]"
			[Register ("addDataSource", "(Lcom/otaliastudios/transcoder/source/DataSource;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;", "GetAddDataSource_Lcom_otaliastudios_transcoder_source_DataSource_Handler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder AddDataSource (global::Com.Otaliastudios.Transcoder.Source.IDataSource dataSource)
			{
				const string __id = "addDataSource.(Lcom/otaliastudios/transcoder/source/DataSource;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((dataSource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSource).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (dataSource);
				}
			}

			static Delegate cb_addDataSource_Ljava_io_FileDescriptor_;
#pragma warning disable 0169
			static Delegate GetAddDataSource_Ljava_io_FileDescriptor_Handler ()
			{
				if (cb_addDataSource_Ljava_io_FileDescriptor_ == null)
					cb_addDataSource_Ljava_io_FileDescriptor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddDataSource_Ljava_io_FileDescriptor_);
				return cb_addDataSource_Ljava_io_FileDescriptor_;
			}

			static IntPtr n_AddDataSource_Ljava_io_FileDescriptor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fileDescriptor)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var fileDescriptor = global::Java.Lang.Object.GetObject<global::Java.IO.FileDescriptor> (native_fileDescriptor, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddDataSource (fileDescriptor));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions.Builder']/method[@name='addDataSource' and count(parameter)=1 and parameter[1][@type='java.io.FileDescriptor']]"
			[Register ("addDataSource", "(Ljava/io/FileDescriptor;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;", "GetAddDataSource_Ljava_io_FileDescriptor_Handler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder AddDataSource (global::Java.IO.FileDescriptor fileDescriptor)
			{
				const string __id = "addDataSource.(Ljava/io/FileDescriptor;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((fileDescriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fileDescriptor).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (fileDescriptor);
				}
			}

			static Delegate cb_addDataSource_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAddDataSource_Ljava_lang_String_Handler ()
			{
				if (cb_addDataSource_Ljava_lang_String_ == null)
					cb_addDataSource_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddDataSource_Ljava_lang_String_);
				return cb_addDataSource_Ljava_lang_String_;
			}

			static IntPtr n_AddDataSource_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inPath)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var inPath = JNIEnv.GetString (native_inPath, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddDataSource (inPath));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions.Builder']/method[@name='addDataSource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("addDataSource", "(Ljava/lang/String;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;", "GetAddDataSource_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder AddDataSource (string inPath)
			{
				const string __id = "addDataSource.(Ljava/lang/String;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;";
				IntPtr native_inPath = JNIEnv.NewString (inPath);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_inPath);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_inPath);
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/otaliastudios/transcoder/TranscoderOptions;", "GetBuildHandler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.TranscoderOptions Build ()
			{
				const string __id = "build.()Lcom/otaliastudios/transcoder/TranscoderOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setAudioResampler_Lcom_otaliastudios_transcoder_resample_AudioResampler_;
#pragma warning disable 0169
			static Delegate GetSetAudioResampler_Lcom_otaliastudios_transcoder_resample_AudioResampler_Handler ()
			{
				if (cb_setAudioResampler_Lcom_otaliastudios_transcoder_resample_AudioResampler_ == null)
					cb_setAudioResampler_Lcom_otaliastudios_transcoder_resample_AudioResampler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetAudioResampler_Lcom_otaliastudios_transcoder_resample_AudioResampler_);
				return cb_setAudioResampler_Lcom_otaliastudios_transcoder_resample_AudioResampler_;
			}

			static IntPtr n_SetAudioResampler_Lcom_otaliastudios_transcoder_resample_AudioResampler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_audioResampler)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var audioResampler = (global::Com.Otaliastudios.Transcoder.Resample.IAudioResampler)global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Resample.IAudioResampler> (native_audioResampler, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAudioResampler (audioResampler));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions.Builder']/method[@name='setAudioResampler' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.resample.AudioResampler']]"
			[Register ("setAudioResampler", "(Lcom/otaliastudios/transcoder/resample/AudioResampler;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;", "GetSetAudioResampler_Lcom_otaliastudios_transcoder_resample_AudioResampler_Handler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder SetAudioResampler (global::Com.Otaliastudios.Transcoder.Resample.IAudioResampler audioResampler)
			{
				const string __id = "setAudioResampler.(Lcom/otaliastudios/transcoder/resample/AudioResampler;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((audioResampler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioResampler).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (audioResampler);
				}
			}

			static Delegate cb_setAudioStretcher_Lcom_otaliastudios_transcoder_stretch_AudioStretcher_;
#pragma warning disable 0169
			static Delegate GetSetAudioStretcher_Lcom_otaliastudios_transcoder_stretch_AudioStretcher_Handler ()
			{
				if (cb_setAudioStretcher_Lcom_otaliastudios_transcoder_stretch_AudioStretcher_ == null)
					cb_setAudioStretcher_Lcom_otaliastudios_transcoder_stretch_AudioStretcher_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetAudioStretcher_Lcom_otaliastudios_transcoder_stretch_AudioStretcher_);
				return cb_setAudioStretcher_Lcom_otaliastudios_transcoder_stretch_AudioStretcher_;
			}

			static IntPtr n_SetAudioStretcher_Lcom_otaliastudios_transcoder_stretch_AudioStretcher_ (IntPtr jnienv, IntPtr native__this, IntPtr native_audioStretcher)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var audioStretcher = (global::Com.Otaliastudios.Transcoder.Stretch.IAudioStretcher)global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Stretch.IAudioStretcher> (native_audioStretcher, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAudioStretcher (audioStretcher));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions.Builder']/method[@name='setAudioStretcher' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.stretch.AudioStretcher']]"
			[Register ("setAudioStretcher", "(Lcom/otaliastudios/transcoder/stretch/AudioStretcher;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;", "GetSetAudioStretcher_Lcom_otaliastudios_transcoder_stretch_AudioStretcher_Handler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder SetAudioStretcher (global::Com.Otaliastudios.Transcoder.Stretch.IAudioStretcher audioStretcher)
			{
				const string __id = "setAudioStretcher.(Lcom/otaliastudios/transcoder/stretch/AudioStretcher;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((audioStretcher == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audioStretcher).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (audioStretcher);
				}
			}

			static Delegate cb_setAudioTrackStrategy_Lcom_otaliastudios_transcoder_strategy_TrackStrategy_;
#pragma warning disable 0169
			static Delegate GetSetAudioTrackStrategy_Lcom_otaliastudios_transcoder_strategy_TrackStrategy_Handler ()
			{
				if (cb_setAudioTrackStrategy_Lcom_otaliastudios_transcoder_strategy_TrackStrategy_ == null)
					cb_setAudioTrackStrategy_Lcom_otaliastudios_transcoder_strategy_TrackStrategy_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetAudioTrackStrategy_Lcom_otaliastudios_transcoder_strategy_TrackStrategy_);
				return cb_setAudioTrackStrategy_Lcom_otaliastudios_transcoder_strategy_TrackStrategy_;
			}

			static IntPtr n_SetAudioTrackStrategy_Lcom_otaliastudios_transcoder_strategy_TrackStrategy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_trackStrategy)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var trackStrategy = (global::Com.Otaliastudios.Transcoder.Strategy.ITrackStrategy)global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.ITrackStrategy> (native_trackStrategy, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAudioTrackStrategy (trackStrategy));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions.Builder']/method[@name='setAudioTrackStrategy' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.strategy.TrackStrategy']]"
			[Register ("setAudioTrackStrategy", "(Lcom/otaliastudios/transcoder/strategy/TrackStrategy;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;", "GetSetAudioTrackStrategy_Lcom_otaliastudios_transcoder_strategy_TrackStrategy_Handler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder SetAudioTrackStrategy (global::Com.Otaliastudios.Transcoder.Strategy.ITrackStrategy trackStrategy)
			{
				const string __id = "setAudioTrackStrategy.(Lcom/otaliastudios/transcoder/strategy/TrackStrategy;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((trackStrategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackStrategy).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (trackStrategy);
				}
			}

			static Delegate cb_setListener_Lcom_otaliastudios_transcoder_TranscoderListener_;
#pragma warning disable 0169
			static Delegate GetSetListener_Lcom_otaliastudios_transcoder_TranscoderListener_Handler ()
			{
				if (cb_setListener_Lcom_otaliastudios_transcoder_TranscoderListener_ == null)
					cb_setListener_Lcom_otaliastudios_transcoder_TranscoderListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetListener_Lcom_otaliastudios_transcoder_TranscoderListener_);
				return cb_setListener_Lcom_otaliastudios_transcoder_TranscoderListener_;
			}

			static IntPtr n_SetListener_Lcom_otaliastudios_transcoder_TranscoderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var listener = (global::Com.Otaliastudios.Transcoder.ITranscoderListener)global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.ITranscoderListener> (native_listener, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetListener (listener));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions.Builder']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.TranscoderListener']]"
			[Register ("setListener", "(Lcom/otaliastudios/transcoder/TranscoderListener;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;", "GetSetListener_Lcom_otaliastudios_transcoder_TranscoderListener_Handler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder SetListener (global::Com.Otaliastudios.Transcoder.ITranscoderListener listener)
			{
				const string __id = "setListener.(Lcom/otaliastudios/transcoder/TranscoderListener;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (listener);
				}
			}

			static Delegate cb_setListenerHandler_Landroid_os_Handler_;
#pragma warning disable 0169
			static Delegate GetSetListenerHandler_Landroid_os_Handler_Handler ()
			{
				if (cb_setListenerHandler_Landroid_os_Handler_ == null)
					cb_setListenerHandler_Landroid_os_Handler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetListenerHandler_Landroid_os_Handler_);
				return cb_setListenerHandler_Landroid_os_Handler_;
			}

			static IntPtr n_SetListenerHandler_Landroid_os_Handler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listenerHandler)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var listenerHandler = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_listenerHandler, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetListenerHandler (listenerHandler));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions.Builder']/method[@name='setListenerHandler' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
			[Register ("setListenerHandler", "(Landroid/os/Handler;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;", "GetSetListenerHandler_Landroid_os_Handler_Handler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder SetListenerHandler (global::Android.OS.Handler listenerHandler)
			{
				const string __id = "setListenerHandler.(Landroid/os/Handler;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((listenerHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listenerHandler).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (listenerHandler);
				}
			}

			static Delegate cb_setSpeed_F;
#pragma warning disable 0169
			static Delegate GetSetSpeed_FHandler ()
			{
				if (cb_setSpeed_F == null)
					cb_setSpeed_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_L) n_SetSpeed_F);
				return cb_setSpeed_F;
			}

			static IntPtr n_SetSpeed_F (IntPtr jnienv, IntPtr native__this, float speedFactor)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetSpeed (speedFactor));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions.Builder']/method[@name='setSpeed' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setSpeed", "(F)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;", "GetSetSpeed_FHandler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder SetSpeed (float speedFactor)
			{
				const string __id = "setSpeed.(F)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (speedFactor);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setTimeInterpolator_Lcom_otaliastudios_transcoder_time_TimeInterpolator_;
#pragma warning disable 0169
			static Delegate GetSetTimeInterpolator_Lcom_otaliastudios_transcoder_time_TimeInterpolator_Handler ()
			{
				if (cb_setTimeInterpolator_Lcom_otaliastudios_transcoder_time_TimeInterpolator_ == null)
					cb_setTimeInterpolator_Lcom_otaliastudios_transcoder_time_TimeInterpolator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTimeInterpolator_Lcom_otaliastudios_transcoder_time_TimeInterpolator_);
				return cb_setTimeInterpolator_Lcom_otaliastudios_transcoder_time_TimeInterpolator_;
			}

			static IntPtr n_SetTimeInterpolator_Lcom_otaliastudios_transcoder_time_TimeInterpolator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_timeInterpolator)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var timeInterpolator = (global::Com.Otaliastudios.Transcoder.Time.ITimeInterpolator)global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Time.ITimeInterpolator> (native_timeInterpolator, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTimeInterpolator (timeInterpolator));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions.Builder']/method[@name='setTimeInterpolator' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.time.TimeInterpolator']]"
			[Register ("setTimeInterpolator", "(Lcom/otaliastudios/transcoder/time/TimeInterpolator;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;", "GetSetTimeInterpolator_Lcom_otaliastudios_transcoder_time_TimeInterpolator_Handler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder SetTimeInterpolator (global::Com.Otaliastudios.Transcoder.Time.ITimeInterpolator timeInterpolator)
			{
				const string __id = "setTimeInterpolator.(Lcom/otaliastudios/transcoder/time/TimeInterpolator;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((timeInterpolator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeInterpolator).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (timeInterpolator);
				}
			}

			static Delegate cb_setValidator_Lcom_otaliastudios_transcoder_validator_Validator_;
#pragma warning disable 0169
			static Delegate GetSetValidator_Lcom_otaliastudios_transcoder_validator_Validator_Handler ()
			{
				if (cb_setValidator_Lcom_otaliastudios_transcoder_validator_Validator_ == null)
					cb_setValidator_Lcom_otaliastudios_transcoder_validator_Validator_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetValidator_Lcom_otaliastudios_transcoder_validator_Validator_);
				return cb_setValidator_Lcom_otaliastudios_transcoder_validator_Validator_;
			}

			static IntPtr n_SetValidator_Lcom_otaliastudios_transcoder_validator_Validator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_validator)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var validator = (global::Com.Otaliastudios.Transcoder.Validator.IValidator)global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Validator.IValidator> (native_validator, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetValidator (validator));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions.Builder']/method[@name='setValidator' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.validator.Validator']]"
			[Register ("setValidator", "(Lcom/otaliastudios/transcoder/validator/Validator;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;", "GetSetValidator_Lcom_otaliastudios_transcoder_validator_Validator_Handler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder SetValidator (global::Com.Otaliastudios.Transcoder.Validator.IValidator validator)
			{
				const string __id = "setValidator.(Lcom/otaliastudios/transcoder/validator/Validator;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((validator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) validator).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (validator);
				}
			}

			static Delegate cb_setVideoRotation_I;
#pragma warning disable 0169
			static Delegate GetSetVideoRotation_IHandler ()
			{
				if (cb_setVideoRotation_I == null)
					cb_setVideoRotation_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetVideoRotation_I);
				return cb_setVideoRotation_I;
			}

			static IntPtr n_SetVideoRotation_I (IntPtr jnienv, IntPtr native__this, int rotation)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetVideoRotation (rotation));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions.Builder']/method[@name='setVideoRotation' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setVideoRotation", "(I)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;", "GetSetVideoRotation_IHandler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder SetVideoRotation (int rotation)
			{
				const string __id = "setVideoRotation.(I)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (rotation);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setVideoTrackStrategy_Lcom_otaliastudios_transcoder_strategy_TrackStrategy_;
#pragma warning disable 0169
			static Delegate GetSetVideoTrackStrategy_Lcom_otaliastudios_transcoder_strategy_TrackStrategy_Handler ()
			{
				if (cb_setVideoTrackStrategy_Lcom_otaliastudios_transcoder_strategy_TrackStrategy_ == null)
					cb_setVideoTrackStrategy_Lcom_otaliastudios_transcoder_strategy_TrackStrategy_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetVideoTrackStrategy_Lcom_otaliastudios_transcoder_strategy_TrackStrategy_);
				return cb_setVideoTrackStrategy_Lcom_otaliastudios_transcoder_strategy_TrackStrategy_;
			}

			static IntPtr n_SetVideoTrackStrategy_Lcom_otaliastudios_transcoder_strategy_TrackStrategy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_trackStrategy)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var trackStrategy = (global::Com.Otaliastudios.Transcoder.Strategy.ITrackStrategy)global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.ITrackStrategy> (native_trackStrategy, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetVideoTrackStrategy (trackStrategy));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions.Builder']/method[@name='setVideoTrackStrategy' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.strategy.TrackStrategy']]"
			[Register ("setVideoTrackStrategy", "(Lcom/otaliastudios/transcoder/strategy/TrackStrategy;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;", "GetSetVideoTrackStrategy_Lcom_otaliastudios_transcoder_strategy_TrackStrategy_Handler")]
			public virtual unsafe global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder SetVideoTrackStrategy (global::Com.Otaliastudios.Transcoder.Strategy.ITrackStrategy trackStrategy)
			{
				const string __id = "setVideoTrackStrategy.(Lcom/otaliastudios/transcoder/strategy/TrackStrategy;)Lcom/otaliastudios/transcoder/TranscoderOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((trackStrategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackStrategy).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (trackStrategy);
				}
			}

			static Delegate cb_transcode;
#pragma warning disable 0169
			static Delegate GetTranscodeHandler ()
			{
				if (cb_transcode == null)
					cb_transcode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Transcode);
				return cb_transcode;
			}

			static IntPtr n_Transcode (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Transcode ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions.Builder']/method[@name='transcode' and count(parameter)=0]"
			[Register ("transcode", "()Ljava/util/concurrent/Future;", "GetTranscodeHandler")]
			public virtual unsafe global::Java.Util.Concurrent.IFuture Transcode ()
			{
				const string __id = "transcode.()Ljava/util/concurrent/Future;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/TranscoderOptions", typeof (TranscoderOptions));

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

		protected TranscoderOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getAudioDataSources;
#pragma warning disable 0169
		static Delegate GetGetAudioDataSourcesHandler ()
		{
			if (cb_getAudioDataSources == null)
				cb_getAudioDataSources = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAudioDataSources);
			return cb_getAudioDataSources;
		}

		static IntPtr n_GetAudioDataSources (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Otaliastudios.Transcoder.Source.IDataSource>.ToLocalJniHandle (__this.AudioDataSources);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Otaliastudios.Transcoder.Source.IDataSource> AudioDataSources {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions']/method[@name='getAudioDataSources' and count(parameter)=0]"
			[Register ("getAudioDataSources", "()Ljava/util/List;", "GetGetAudioDataSourcesHandler")]
			get {
				const string __id = "getAudioDataSources.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Otaliastudios.Transcoder.Source.IDataSource>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAudioResampler;
#pragma warning disable 0169
		static Delegate GetGetAudioResamplerHandler ()
		{
			if (cb_getAudioResampler == null)
				cb_getAudioResampler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAudioResampler);
			return cb_getAudioResampler;
		}

		static IntPtr n_GetAudioResampler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AudioResampler);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Otaliastudios.Transcoder.Resample.IAudioResampler AudioResampler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions']/method[@name='getAudioResampler' and count(parameter)=0]"
			[Register ("getAudioResampler", "()Lcom/otaliastudios/transcoder/resample/AudioResampler;", "GetGetAudioResamplerHandler")]
			get {
				const string __id = "getAudioResampler.()Lcom/otaliastudios/transcoder/resample/AudioResampler;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Resample.IAudioResampler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAudioStretcher;
#pragma warning disable 0169
		static Delegate GetGetAudioStretcherHandler ()
		{
			if (cb_getAudioStretcher == null)
				cb_getAudioStretcher = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAudioStretcher);
			return cb_getAudioStretcher;
		}

		static IntPtr n_GetAudioStretcher (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AudioStretcher);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Otaliastudios.Transcoder.Stretch.IAudioStretcher AudioStretcher {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions']/method[@name='getAudioStretcher' and count(parameter)=0]"
			[Register ("getAudioStretcher", "()Lcom/otaliastudios/transcoder/stretch/AudioStretcher;", "GetGetAudioStretcherHandler")]
			get {
				const string __id = "getAudioStretcher.()Lcom/otaliastudios/transcoder/stretch/AudioStretcher;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Stretch.IAudioStretcher> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAudioTrackStrategy;
#pragma warning disable 0169
		static Delegate GetGetAudioTrackStrategyHandler ()
		{
			if (cb_getAudioTrackStrategy == null)
				cb_getAudioTrackStrategy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAudioTrackStrategy);
			return cb_getAudioTrackStrategy;
		}

		static IntPtr n_GetAudioTrackStrategy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AudioTrackStrategy);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Otaliastudios.Transcoder.Strategy.ITrackStrategy AudioTrackStrategy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions']/method[@name='getAudioTrackStrategy' and count(parameter)=0]"
			[Register ("getAudioTrackStrategy", "()Lcom/otaliastudios/transcoder/strategy/TrackStrategy;", "GetGetAudioTrackStrategyHandler")]
			get {
				const string __id = "getAudioTrackStrategy.()Lcom/otaliastudios/transcoder/strategy/TrackStrategy;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.ITrackStrategy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDataSink;
#pragma warning disable 0169
		static Delegate GetGetDataSinkHandler ()
		{
			if (cb_getDataSink == null)
				cb_getDataSink = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDataSink);
			return cb_getDataSink;
		}

		static IntPtr n_GetDataSink (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DataSink);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Otaliastudios.Transcoder.Sink.IDataSink DataSink {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions']/method[@name='getDataSink' and count(parameter)=0]"
			[Register ("getDataSink", "()Lcom/otaliastudios/transcoder/sink/DataSink;", "GetGetDataSinkHandler")]
			get {
				const string __id = "getDataSink.()Lcom/otaliastudios/transcoder/sink/DataSink;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Sink.IDataSink> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getListener;
#pragma warning disable 0169
		static Delegate GetGetListenerHandler ()
		{
			if (cb_getListener == null)
				cb_getListener = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetListener);
			return cb_getListener;
		}

		static IntPtr n_GetListener (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Listener);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Otaliastudios.Transcoder.ITranscoderListener Listener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions']/method[@name='getListener' and count(parameter)=0]"
			[Register ("getListener", "()Lcom/otaliastudios/transcoder/TranscoderListener;", "GetGetListenerHandler")]
			get {
				const string __id = "getListener.()Lcom/otaliastudios/transcoder/TranscoderListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.ITranscoderListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getListenerHandler;
#pragma warning disable 0169
		static Delegate GetGetListenerHandlerHandler ()
		{
			if (cb_getListenerHandler == null)
				cb_getListenerHandler = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetListenerHandler);
			return cb_getListenerHandler;
		}

		static IntPtr n_GetListenerHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ListenerHandler);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.OS.Handler ListenerHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions']/method[@name='getListenerHandler' and count(parameter)=0]"
			[Register ("getListenerHandler", "()Landroid/os/Handler;", "GetGetListenerHandlerHandler")]
			get {
				const string __id = "getListenerHandler.()Landroid/os/Handler;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTimeInterpolator;
#pragma warning disable 0169
		static Delegate GetGetTimeInterpolatorHandler ()
		{
			if (cb_getTimeInterpolator == null)
				cb_getTimeInterpolator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTimeInterpolator);
			return cb_getTimeInterpolator;
		}

		static IntPtr n_GetTimeInterpolator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TimeInterpolator);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Otaliastudios.Transcoder.Time.ITimeInterpolator TimeInterpolator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions']/method[@name='getTimeInterpolator' and count(parameter)=0]"
			[Register ("getTimeInterpolator", "()Lcom/otaliastudios/transcoder/time/TimeInterpolator;", "GetGetTimeInterpolatorHandler")]
			get {
				const string __id = "getTimeInterpolator.()Lcom/otaliastudios/transcoder/time/TimeInterpolator;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Time.ITimeInterpolator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getValidator;
#pragma warning disable 0169
		static Delegate GetGetValidatorHandler ()
		{
			if (cb_getValidator == null)
				cb_getValidator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetValidator);
			return cb_getValidator;
		}

		static IntPtr n_GetValidator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Validator);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Otaliastudios.Transcoder.Validator.IValidator Validator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions']/method[@name='getValidator' and count(parameter)=0]"
			[Register ("getValidator", "()Lcom/otaliastudios/transcoder/validator/Validator;", "GetGetValidatorHandler")]
			get {
				const string __id = "getValidator.()Lcom/otaliastudios/transcoder/validator/Validator;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Validator.IValidator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoDataSources;
#pragma warning disable 0169
		static Delegate GetGetVideoDataSourcesHandler ()
		{
			if (cb_getVideoDataSources == null)
				cb_getVideoDataSources = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetVideoDataSources);
			return cb_getVideoDataSources;
		}

		static IntPtr n_GetVideoDataSources (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Otaliastudios.Transcoder.Source.IDataSource>.ToLocalJniHandle (__this.VideoDataSources);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Otaliastudios.Transcoder.Source.IDataSource> VideoDataSources {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions']/method[@name='getVideoDataSources' and count(parameter)=0]"
			[Register ("getVideoDataSources", "()Ljava/util/List;", "GetGetVideoDataSourcesHandler")]
			get {
				const string __id = "getVideoDataSources.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Otaliastudios.Transcoder.Source.IDataSource>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoRotation;
#pragma warning disable 0169
		static Delegate GetGetVideoRotationHandler ()
		{
			if (cb_getVideoRotation == null)
				cb_getVideoRotation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetVideoRotation);
			return cb_getVideoRotation;
		}

		static int n_GetVideoRotation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoRotation;
		}
#pragma warning restore 0169

		public virtual unsafe int VideoRotation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions']/method[@name='getVideoRotation' and count(parameter)=0]"
			[Register ("getVideoRotation", "()I", "GetGetVideoRotationHandler")]
			get {
				const string __id = "getVideoRotation.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getVideoTrackStrategy;
#pragma warning disable 0169
		static Delegate GetGetVideoTrackStrategyHandler ()
		{
			if (cb_getVideoTrackStrategy == null)
				cb_getVideoTrackStrategy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetVideoTrackStrategy);
			return cb_getVideoTrackStrategy;
		}

		static IntPtr n_GetVideoTrackStrategy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.TranscoderOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VideoTrackStrategy);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Otaliastudios.Transcoder.Strategy.ITrackStrategy VideoTrackStrategy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='TranscoderOptions']/method[@name='getVideoTrackStrategy' and count(parameter)=0]"
			[Register ("getVideoTrackStrategy", "()Lcom/otaliastudios/transcoder/strategy/TrackStrategy;", "GetGetVideoTrackStrategyHandler")]
			get {
				const string __id = "getVideoTrackStrategy.()Lcom/otaliastudios/transcoder/strategy/TrackStrategy;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Strategy.ITrackStrategy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
