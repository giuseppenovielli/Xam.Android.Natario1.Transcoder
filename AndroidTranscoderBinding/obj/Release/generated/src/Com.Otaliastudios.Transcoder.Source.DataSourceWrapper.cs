using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Source {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='DataSourceWrapper']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/source/DataSourceWrapper", DoNotGenerateAcw=true)]
	public partial class DataSourceWrapper : global::Java.Lang.Object, global::Com.Otaliastudios.Transcoder.Source.IDataSource {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/source/DataSourceWrapper", typeof (DataSourceWrapper));

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

		protected DataSourceWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='DataSourceWrapper']/constructor[@name='DataSourceWrapper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe DataSourceWrapper () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='DataSourceWrapper']/constructor[@name='DataSourceWrapper' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.source.DataSource']]"
		[Register (".ctor", "(Lcom/otaliastudios/transcoder/source/DataSource;)V", "")]
		protected unsafe DataSourceWrapper (global::Com.Otaliastudios.Transcoder.Source.IDataSource source) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/otaliastudios/transcoder/source/DataSource;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (source);
			}
		}

		static Delegate cb_getDurationUs;
#pragma warning disable 0169
		static Delegate GetGetDurationUsHandler ()
		{
			if (cb_getDurationUs == null)
				cb_getDurationUs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetDurationUs);
			return cb_getDurationUs;
		}

		static long n_GetDurationUs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.DataSourceWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DurationUs;
		}
#pragma warning restore 0169

		public virtual unsafe long DurationUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='DataSourceWrapper']/method[@name='getDurationUs' and count(parameter)=0]"
			[Register ("getDurationUs", "()J", "GetGetDurationUsHandler")]
			get {
				const string __id = "getDurationUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDrained;
#pragma warning disable 0169
		static Delegate GetIsDrainedHandler ()
		{
			if (cb_isDrained == null)
				cb_isDrained = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDrained);
			return cb_isDrained;
		}

		static bool n_IsDrained (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.DataSourceWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrained;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDrained {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='DataSourceWrapper']/method[@name='isDrained' and count(parameter)=0]"
			[Register ("isDrained", "()Z", "GetIsDrainedHandler")]
			get {
				const string __id = "isDrained.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isInitialized;
#pragma warning disable 0169
		static Delegate GetIsInitializedHandler ()
		{
			if (cb_isInitialized == null)
				cb_isInitialized = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsInitialized);
			return cb_isInitialized;
		}

		static bool n_IsInitialized (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.DataSourceWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInitialized;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='DataSourceWrapper']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler")]
			get {
				const string __id = "isInitialized.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOrientation;
#pragma warning disable 0169
		static Delegate GetGetOrientationHandler ()
		{
			if (cb_getOrientation == null)
				cb_getOrientation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetOrientation);
			return cb_getOrientation;
		}

		static int n_GetOrientation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.DataSourceWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Orientation;
		}
#pragma warning restore 0169

		public virtual unsafe int Orientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='DataSourceWrapper']/method[@name='getOrientation' and count(parameter)=0]"
			[Register ("getOrientation", "()I", "GetGetOrientationHandler")]
			get {
				const string __id = "getOrientation.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPositionUs;
#pragma warning disable 0169
		static Delegate GetGetPositionUsHandler ()
		{
			if (cb_getPositionUs == null)
				cb_getPositionUs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetPositionUs);
			return cb_getPositionUs;
		}

		static long n_GetPositionUs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.DataSourceWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PositionUs;
		}
#pragma warning restore 0169

		public virtual unsafe long PositionUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='DataSourceWrapper']/method[@name='getPositionUs' and count(parameter)=0]"
			[Register ("getPositionUs", "()J", "GetGetPositionUsHandler")]
			get {
				const string __id = "getPositionUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSource;
#pragma warning disable 0169
		static Delegate GetGetSourceHandler ()
		{
			if (cb_getSource == null)
				cb_getSource = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSource);
			return cb_getSource;
		}

		static IntPtr n_GetSource (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.DataSourceWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Source);
		}
#pragma warning restore 0169

		static Delegate cb_setSource_Lcom_otaliastudios_transcoder_source_DataSource_;
#pragma warning disable 0169
		static Delegate GetSetSource_Lcom_otaliastudios_transcoder_source_DataSource_Handler ()
		{
			if (cb_setSource_Lcom_otaliastudios_transcoder_source_DataSource_ == null)
				cb_setSource_Lcom_otaliastudios_transcoder_source_DataSource_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSource_Lcom_otaliastudios_transcoder_source_DataSource_);
			return cb_setSource_Lcom_otaliastudios_transcoder_source_DataSource_;
		}

		static void n_SetSource_Lcom_otaliastudios_transcoder_source_DataSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.DataSourceWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var source = (global::Com.Otaliastudios.Transcoder.Source.IDataSource)global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.IDataSource> (native_source, JniHandleOwnership.DoNotTransfer);
			__this.Source = source;
		}
#pragma warning restore 0169

		protected virtual unsafe global::Com.Otaliastudios.Transcoder.Source.IDataSource Source {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='DataSourceWrapper']/method[@name='getSource' and count(parameter)=0]"
			[Register ("getSource", "()Lcom/otaliastudios/transcoder/source/DataSource;", "GetGetSourceHandler")]
			get {
				const string __id = "getSource.()Lcom/otaliastudios/transcoder/source/DataSource;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.IDataSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='DataSourceWrapper']/method[@name='setSource' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.source.DataSource']]"
			[Register ("setSource", "(Lcom/otaliastudios/transcoder/source/DataSource;)V", "GetSetSource_Lcom_otaliastudios_transcoder_source_DataSource_Handler")]
			set {
				const string __id = "setSource.(Lcom/otaliastudios/transcoder/source/DataSource;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_canReadTrack_Lcom_otaliastudios_transcoder_common_TrackType_;
#pragma warning disable 0169
		static Delegate GetCanReadTrack_Lcom_otaliastudios_transcoder_common_TrackType_Handler ()
		{
			if (cb_canReadTrack_Lcom_otaliastudios_transcoder_common_TrackType_ == null)
				cb_canReadTrack_Lcom_otaliastudios_transcoder_common_TrackType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_CanReadTrack_Lcom_otaliastudios_transcoder_common_TrackType_);
			return cb_canReadTrack_Lcom_otaliastudios_transcoder_common_TrackType_;
		}

		static bool n_CanReadTrack_Lcom_otaliastudios_transcoder_common_TrackType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.DataSourceWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var type = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (native_type, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanReadTrack (type);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='DataSourceWrapper']/method[@name='canReadTrack' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackType']]"
		[Register ("canReadTrack", "(Lcom/otaliastudios/transcoder/common/TrackType;)Z", "GetCanReadTrack_Lcom_otaliastudios_transcoder_common_TrackType_Handler")]
		public virtual unsafe bool CanReadTrack (global::Com.Otaliastudios.Transcoder.Common.TrackType type)
		{
			const string __id = "canReadTrack.(Lcom/otaliastudios/transcoder/common/TrackType;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (type);
			}
		}

		static Delegate cb_deinitialize;
#pragma warning disable 0169
		static Delegate GetDeinitializeHandler ()
		{
			if (cb_deinitialize == null)
				cb_deinitialize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Deinitialize);
			return cb_deinitialize;
		}

		static void n_Deinitialize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.DataSourceWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Deinitialize ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='DataSourceWrapper']/method[@name='deinitialize' and count(parameter)=0]"
		[Register ("deinitialize", "()V", "GetDeinitializeHandler")]
		public virtual unsafe void Deinitialize ()
		{
			const string __id = "deinitialize.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getLocation;
#pragma warning disable 0169
		static Delegate GetGetLocationHandler ()
		{
			if (cb_getLocation == null)
				cb_getLocation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLocation);
			return cb_getLocation;
		}

		static IntPtr n_GetLocation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.DataSourceWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetLocation ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='DataSourceWrapper']/method[@name='getLocation' and count(parameter)=0]"
		[Register ("getLocation", "()[D", "GetGetLocationHandler")]
		public virtual unsafe double[] GetLocation ()
		{
			const string __id = "getLocation.()[D";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (double[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		static Delegate cb_getTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_;
#pragma warning disable 0169
		static Delegate GetGetTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_Handler ()
		{
			if (cb_getTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_ == null)
				cb_getTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_);
			return cb_getTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_;
		}

		static IntPtr n_GetTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.DataSourceWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var type = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (native_type, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTrackFormat (type));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='DataSourceWrapper']/method[@name='getTrackFormat' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackType']]"
		[Register ("getTrackFormat", "(Lcom/otaliastudios/transcoder/common/TrackType;)Landroid/media/MediaFormat;", "GetGetTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_Handler")]
		public virtual unsafe global::Android.Media.MediaFormat GetTrackFormat (global::Com.Otaliastudios.Transcoder.Common.TrackType type)
		{
			const string __id = "getTrackFormat.(Lcom/otaliastudios/transcoder/common/TrackType;)Landroid/media/MediaFormat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Media.MediaFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (type);
			}
		}

		static Delegate cb_initialize;
#pragma warning disable 0169
		static Delegate GetInitializeHandler ()
		{
			if (cb_initialize == null)
				cb_initialize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Initialize);
			return cb_initialize;
		}

		static void n_Initialize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.DataSourceWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Initialize ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='DataSourceWrapper']/method[@name='initialize' and count(parameter)=0]"
		[Register ("initialize", "()V", "GetInitializeHandler")]
		public virtual unsafe void Initialize ()
		{
			const string __id = "initialize.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_readTrack_Lcom_otaliastudios_transcoder_source_DataSource_Chunk_;
#pragma warning disable 0169
		static Delegate GetReadTrack_Lcom_otaliastudios_transcoder_source_DataSource_Chunk_Handler ()
		{
			if (cb_readTrack_Lcom_otaliastudios_transcoder_source_DataSource_Chunk_ == null)
				cb_readTrack_Lcom_otaliastudios_transcoder_source_DataSource_Chunk_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ReadTrack_Lcom_otaliastudios_transcoder_source_DataSource_Chunk_);
			return cb_readTrack_Lcom_otaliastudios_transcoder_source_DataSource_Chunk_;
		}

		static void n_ReadTrack_Lcom_otaliastudios_transcoder_source_DataSource_Chunk_ (IntPtr jnienv, IntPtr native__this, IntPtr native_chunk)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.DataSourceWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var chunk = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.DataSourceChunk> (native_chunk, JniHandleOwnership.DoNotTransfer);
			__this.ReadTrack (chunk);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='DataSourceWrapper']/method[@name='readTrack' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.source.DataSource.Chunk']]"
		[Register ("readTrack", "(Lcom/otaliastudios/transcoder/source/DataSource$Chunk;)V", "GetReadTrack_Lcom_otaliastudios_transcoder_source_DataSource_Chunk_Handler")]
		public virtual unsafe void ReadTrack (global::Com.Otaliastudios.Transcoder.Source.DataSourceChunk chunk)
		{
			const string __id = "readTrack.(Lcom/otaliastudios/transcoder/source/DataSource$Chunk;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((chunk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) chunk).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (chunk);
			}
		}

		static Delegate cb_releaseTrack_Lcom_otaliastudios_transcoder_common_TrackType_;
#pragma warning disable 0169
		static Delegate GetReleaseTrack_Lcom_otaliastudios_transcoder_common_TrackType_Handler ()
		{
			if (cb_releaseTrack_Lcom_otaliastudios_transcoder_common_TrackType_ == null)
				cb_releaseTrack_Lcom_otaliastudios_transcoder_common_TrackType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ReleaseTrack_Lcom_otaliastudios_transcoder_common_TrackType_);
			return cb_releaseTrack_Lcom_otaliastudios_transcoder_common_TrackType_;
		}

		static void n_ReleaseTrack_Lcom_otaliastudios_transcoder_common_TrackType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.DataSourceWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var type = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (native_type, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseTrack (type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='DataSourceWrapper']/method[@name='releaseTrack' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackType']]"
		[Register ("releaseTrack", "(Lcom/otaliastudios/transcoder/common/TrackType;)V", "GetReleaseTrack_Lcom_otaliastudios_transcoder_common_TrackType_Handler")]
		public virtual unsafe void ReleaseTrack (global::Com.Otaliastudios.Transcoder.Common.TrackType type)
		{
			const string __id = "releaseTrack.(Lcom/otaliastudios/transcoder/common/TrackType;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (type);
			}
		}

		static Delegate cb_seekTo_J;
#pragma warning disable 0169
		static Delegate GetSeekTo_JHandler ()
		{
			if (cb_seekTo_J == null)
				cb_seekTo_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_J) n_SeekTo_J);
			return cb_seekTo_J;
		}

		static long n_SeekTo_J (IntPtr jnienv, IntPtr native__this, long desiredPositionUs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.DataSourceWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SeekTo (desiredPositionUs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='DataSourceWrapper']/method[@name='seekTo' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("seekTo", "(J)J", "GetSeekTo_JHandler")]
		public virtual unsafe long SeekTo (long desiredPositionUs)
		{
			const string __id = "seekTo.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (desiredPositionUs);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_selectTrack_Lcom_otaliastudios_transcoder_common_TrackType_;
#pragma warning disable 0169
		static Delegate GetSelectTrack_Lcom_otaliastudios_transcoder_common_TrackType_Handler ()
		{
			if (cb_selectTrack_Lcom_otaliastudios_transcoder_common_TrackType_ == null)
				cb_selectTrack_Lcom_otaliastudios_transcoder_common_TrackType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SelectTrack_Lcom_otaliastudios_transcoder_common_TrackType_);
			return cb_selectTrack_Lcom_otaliastudios_transcoder_common_TrackType_;
		}

		static void n_SelectTrack_Lcom_otaliastudios_transcoder_common_TrackType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.DataSourceWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var type = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (native_type, JniHandleOwnership.DoNotTransfer);
			__this.SelectTrack (type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='DataSourceWrapper']/method[@name='selectTrack' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackType']]"
		[Register ("selectTrack", "(Lcom/otaliastudios/transcoder/common/TrackType;)V", "GetSelectTrack_Lcom_otaliastudios_transcoder_common_TrackType_Handler")]
		public virtual unsafe void SelectTrack (global::Com.Otaliastudios.Transcoder.Common.TrackType type)
		{
			const string __id = "selectTrack.(Lcom/otaliastudios/transcoder/common/TrackType;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (type);
			}
		}

	}
}
