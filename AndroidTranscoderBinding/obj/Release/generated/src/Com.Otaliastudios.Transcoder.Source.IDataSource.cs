using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Source {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='DataSource.Chunk']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/source/DataSource$Chunk", DoNotGenerateAcw=true)]
	public partial class DataSourceChunk : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='DataSource.Chunk']/field[@name='buffer']"
		[Register ("buffer")]
		public global::Java.Nio.ByteBuffer Buffer {
			get {
				const string __id = "buffer.Ljava/nio/ByteBuffer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "buffer.Ljava/nio/ByteBuffer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='DataSource.Chunk']/field[@name='keyframe']"
		[Register ("keyframe")]
		public bool Keyframe {
			get {
				const string __id = "keyframe.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "keyframe.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='DataSource.Chunk']/field[@name='render']"
		[Register ("render")]
		public bool Render {
			get {
				const string __id = "render.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "render.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='DataSource.Chunk']/field[@name='timeUs']"
		[Register ("timeUs")]
		public long TimeUs {
			get {
				const string __id = "timeUs.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "timeUs.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/source/DataSource$Chunk", typeof (DataSourceChunk));

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

		protected DataSourceChunk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='DataSource.Chunk']/constructor[@name='DataSource.Chunk' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DataSourceChunk () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/interface[@name='DataSource']"
	[Register ("com/otaliastudios/transcoder/source/DataSource", "", "Com.Otaliastudios.Transcoder.Source.IDataSourceInvoker")]
	public partial interface IDataSource : IJavaObject, IJavaPeerable {
		long DurationUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/interface[@name='DataSource']/method[@name='getDurationUs' and count(parameter)=0]"
			[Register ("getDurationUs", "()J", "GetGetDurationUsHandler:Com.Otaliastudios.Transcoder.Source.IDataSourceInvoker, AndroidTranscoderBinding")]
			get; 
		}

		bool IsDrained {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/interface[@name='DataSource']/method[@name='isDrained' and count(parameter)=0]"
			[Register ("isDrained", "()Z", "GetIsDrainedHandler:Com.Otaliastudios.Transcoder.Source.IDataSourceInvoker, AndroidTranscoderBinding")]
			get; 
		}

		bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/interface[@name='DataSource']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler:Com.Otaliastudios.Transcoder.Source.IDataSourceInvoker, AndroidTranscoderBinding")]
			get; 
		}

		int Orientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/interface[@name='DataSource']/method[@name='getOrientation' and count(parameter)=0]"
			[Register ("getOrientation", "()I", "GetGetOrientationHandler:Com.Otaliastudios.Transcoder.Source.IDataSourceInvoker, AndroidTranscoderBinding")]
			get; 
		}

		long PositionUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/interface[@name='DataSource']/method[@name='getPositionUs' and count(parameter)=0]"
			[Register ("getPositionUs", "()J", "GetGetPositionUsHandler:Com.Otaliastudios.Transcoder.Source.IDataSourceInvoker, AndroidTranscoderBinding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/interface[@name='DataSource']/method[@name='canReadTrack' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackType']]"
		[Register ("canReadTrack", "(Lcom/otaliastudios/transcoder/common/TrackType;)Z", "GetCanReadTrack_Lcom_otaliastudios_transcoder_common_TrackType_Handler:Com.Otaliastudios.Transcoder.Source.IDataSourceInvoker, AndroidTranscoderBinding")]
		bool CanReadTrack (global::Com.Otaliastudios.Transcoder.Common.TrackType p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/interface[@name='DataSource']/method[@name='deinitialize' and count(parameter)=0]"
		[Register ("deinitialize", "()V", "GetDeinitializeHandler:Com.Otaliastudios.Transcoder.Source.IDataSourceInvoker, AndroidTranscoderBinding")]
		void Deinitialize ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/interface[@name='DataSource']/method[@name='getLocation' and count(parameter)=0]"
		[Register ("getLocation", "()[D", "GetGetLocationHandler:Com.Otaliastudios.Transcoder.Source.IDataSourceInvoker, AndroidTranscoderBinding")]
		double[] GetLocation ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/interface[@name='DataSource']/method[@name='getTrackFormat' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackType']]"
		[Register ("getTrackFormat", "(Lcom/otaliastudios/transcoder/common/TrackType;)Landroid/media/MediaFormat;", "GetGetTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_Handler:Com.Otaliastudios.Transcoder.Source.IDataSourceInvoker, AndroidTranscoderBinding")]
		global::Android.Media.MediaFormat GetTrackFormat (global::Com.Otaliastudios.Transcoder.Common.TrackType p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/interface[@name='DataSource']/method[@name='initialize' and count(parameter)=0]"
		[Register ("initialize", "()V", "GetInitializeHandler:Com.Otaliastudios.Transcoder.Source.IDataSourceInvoker, AndroidTranscoderBinding")]
		void Initialize ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/interface[@name='DataSource']/method[@name='readTrack' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.source.DataSource.Chunk']]"
		[Register ("readTrack", "(Lcom/otaliastudios/transcoder/source/DataSource$Chunk;)V", "GetReadTrack_Lcom_otaliastudios_transcoder_source_DataSource_Chunk_Handler:Com.Otaliastudios.Transcoder.Source.IDataSourceInvoker, AndroidTranscoderBinding")]
		void ReadTrack (global::Com.Otaliastudios.Transcoder.Source.DataSourceChunk p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/interface[@name='DataSource']/method[@name='releaseTrack' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackType']]"
		[Register ("releaseTrack", "(Lcom/otaliastudios/transcoder/common/TrackType;)V", "GetReleaseTrack_Lcom_otaliastudios_transcoder_common_TrackType_Handler:Com.Otaliastudios.Transcoder.Source.IDataSourceInvoker, AndroidTranscoderBinding")]
		void ReleaseTrack (global::Com.Otaliastudios.Transcoder.Common.TrackType p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/interface[@name='DataSource']/method[@name='seekTo' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("seekTo", "(J)J", "GetSeekTo_JHandler:Com.Otaliastudios.Transcoder.Source.IDataSourceInvoker, AndroidTranscoderBinding")]
		long SeekTo (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/interface[@name='DataSource']/method[@name='selectTrack' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackType']]"
		[Register ("selectTrack", "(Lcom/otaliastudios/transcoder/common/TrackType;)V", "GetSelectTrack_Lcom_otaliastudios_transcoder_common_TrackType_Handler:Com.Otaliastudios.Transcoder.Source.IDataSourceInvoker, AndroidTranscoderBinding")]
		void SelectTrack (global::Com.Otaliastudios.Transcoder.Common.TrackType p0);

	}

	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/source/DataSource", DoNotGenerateAcw=true)]
	internal partial class IDataSourceInvoker : global::Java.Lang.Object, IDataSource {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/source/DataSource", typeof (IDataSourceInvoker));

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

		public static IDataSource GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDataSource> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.otaliastudios.transcoder.source.DataSource'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDataSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DurationUs;
		}
#pragma warning restore 0169

		IntPtr id_getDurationUs;
		public unsafe long DurationUs {
			get {
				if (id_getDurationUs == IntPtr.Zero)
					id_getDurationUs = JNIEnv.GetMethodID (class_ref, "getDurationUs", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDurationUs);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrained;
		}
#pragma warning restore 0169

		IntPtr id_isDrained;
		public unsafe bool IsDrained {
			get {
				if (id_isDrained == IntPtr.Zero)
					id_isDrained = JNIEnv.GetMethodID (class_ref, "isDrained", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDrained);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInitialized;
		}
#pragma warning restore 0169

		IntPtr id_isInitialized;
		public unsafe bool IsInitialized {
			get {
				if (id_isInitialized == IntPtr.Zero)
					id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInitialized);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Orientation;
		}
#pragma warning restore 0169

		IntPtr id_getOrientation;
		public unsafe int Orientation {
			get {
				if (id_getOrientation == IntPtr.Zero)
					id_getOrientation = JNIEnv.GetMethodID (class_ref, "getOrientation", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getOrientation);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PositionUs;
		}
#pragma warning restore 0169

		IntPtr id_getPositionUs;
		public unsafe long PositionUs {
			get {
				if (id_getPositionUs == IntPtr.Zero)
					id_getPositionUs = JNIEnv.GetMethodID (class_ref, "getPositionUs", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPositionUs);
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

		static bool n_CanReadTrack_Lcom_otaliastudios_transcoder_common_TrackType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanReadTrack (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_canReadTrack_Lcom_otaliastudios_transcoder_common_TrackType_;
		public unsafe bool CanReadTrack (global::Com.Otaliastudios.Transcoder.Common.TrackType p0)
		{
			if (id_canReadTrack_Lcom_otaliastudios_transcoder_common_TrackType_ == IntPtr.Zero)
				id_canReadTrack_Lcom_otaliastudios_transcoder_common_TrackType_ = JNIEnv.GetMethodID (class_ref, "canReadTrack", "(Lcom/otaliastudios/transcoder/common/TrackType;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canReadTrack_Lcom_otaliastudios_transcoder_common_TrackType_, __args);
			return __ret;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Deinitialize ();
		}
#pragma warning restore 0169

		IntPtr id_deinitialize;
		public unsafe void Deinitialize ()
		{
			if (id_deinitialize == IntPtr.Zero)
				id_deinitialize = JNIEnv.GetMethodID (class_ref, "deinitialize", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deinitialize);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetLocation ());
		}
#pragma warning restore 0169

		IntPtr id_getLocation;
		public unsafe double[] GetLocation ()
		{
			if (id_getLocation == IntPtr.Zero)
				id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()[D");
			return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocation), JniHandleOwnership.TransferLocalRef, typeof (double));
		}

		static Delegate cb_getTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_;
#pragma warning disable 0169
		static Delegate GetGetTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_Handler ()
		{
			if (cb_getTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_ == null)
				cb_getTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_);
			return cb_getTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_;
		}

		static IntPtr n_GetTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTrackFormat (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_;
		public unsafe global::Android.Media.MediaFormat GetTrackFormat (global::Com.Otaliastudios.Transcoder.Common.TrackType p0)
		{
			if (id_getTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_ == IntPtr.Zero)
				id_getTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_ = JNIEnv.GetMethodID (class_ref, "getTrackFormat", "(Lcom/otaliastudios/transcoder/common/TrackType;)Landroid/media/MediaFormat;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Android.Media.MediaFormat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrackFormat_Lcom_otaliastudios_transcoder_common_TrackType_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Initialize ();
		}
#pragma warning restore 0169

		IntPtr id_initialize;
		public unsafe void Initialize ()
		{
			if (id_initialize == IntPtr.Zero)
				id_initialize = JNIEnv.GetMethodID (class_ref, "initialize", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initialize);
		}

		static Delegate cb_readTrack_Lcom_otaliastudios_transcoder_source_DataSource_Chunk_;
#pragma warning disable 0169
		static Delegate GetReadTrack_Lcom_otaliastudios_transcoder_source_DataSource_Chunk_Handler ()
		{
			if (cb_readTrack_Lcom_otaliastudios_transcoder_source_DataSource_Chunk_ == null)
				cb_readTrack_Lcom_otaliastudios_transcoder_source_DataSource_Chunk_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ReadTrack_Lcom_otaliastudios_transcoder_source_DataSource_Chunk_);
			return cb_readTrack_Lcom_otaliastudios_transcoder_source_DataSource_Chunk_;
		}

		static void n_ReadTrack_Lcom_otaliastudios_transcoder_source_DataSource_Chunk_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.DataSourceChunk> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReadTrack (p0);
		}
#pragma warning restore 0169

		IntPtr id_readTrack_Lcom_otaliastudios_transcoder_source_DataSource_Chunk_;
		public unsafe void ReadTrack (global::Com.Otaliastudios.Transcoder.Source.DataSourceChunk p0)
		{
			if (id_readTrack_Lcom_otaliastudios_transcoder_source_DataSource_Chunk_ == IntPtr.Zero)
				id_readTrack_Lcom_otaliastudios_transcoder_source_DataSource_Chunk_ = JNIEnv.GetMethodID (class_ref, "readTrack", "(Lcom/otaliastudios/transcoder/source/DataSource$Chunk;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readTrack_Lcom_otaliastudios_transcoder_source_DataSource_Chunk_, __args);
		}

		static Delegate cb_releaseTrack_Lcom_otaliastudios_transcoder_common_TrackType_;
#pragma warning disable 0169
		static Delegate GetReleaseTrack_Lcom_otaliastudios_transcoder_common_TrackType_Handler ()
		{
			if (cb_releaseTrack_Lcom_otaliastudios_transcoder_common_TrackType_ == null)
				cb_releaseTrack_Lcom_otaliastudios_transcoder_common_TrackType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ReleaseTrack_Lcom_otaliastudios_transcoder_common_TrackType_);
			return cb_releaseTrack_Lcom_otaliastudios_transcoder_common_TrackType_;
		}

		static void n_ReleaseTrack_Lcom_otaliastudios_transcoder_common_TrackType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseTrack (p0);
		}
#pragma warning restore 0169

		IntPtr id_releaseTrack_Lcom_otaliastudios_transcoder_common_TrackType_;
		public unsafe void ReleaseTrack (global::Com.Otaliastudios.Transcoder.Common.TrackType p0)
		{
			if (id_releaseTrack_Lcom_otaliastudios_transcoder_common_TrackType_ == IntPtr.Zero)
				id_releaseTrack_Lcom_otaliastudios_transcoder_common_TrackType_ = JNIEnv.GetMethodID (class_ref, "releaseTrack", "(Lcom/otaliastudios/transcoder/common/TrackType;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_releaseTrack_Lcom_otaliastudios_transcoder_common_TrackType_, __args);
		}

		static Delegate cb_seekTo_J;
#pragma warning disable 0169
		static Delegate GetSeekTo_JHandler ()
		{
			if (cb_seekTo_J == null)
				cb_seekTo_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_J) n_SeekTo_J);
			return cb_seekTo_J;
		}

		static long n_SeekTo_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SeekTo (p0);
		}
#pragma warning restore 0169

		IntPtr id_seekTo_J;
		public unsafe long SeekTo (long p0)
		{
			if (id_seekTo_J == IntPtr.Zero)
				id_seekTo_J = JNIEnv.GetMethodID (class_ref, "seekTo", "(J)J");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_seekTo_J, __args);
		}

		static Delegate cb_selectTrack_Lcom_otaliastudios_transcoder_common_TrackType_;
#pragma warning disable 0169
		static Delegate GetSelectTrack_Lcom_otaliastudios_transcoder_common_TrackType_Handler ()
		{
			if (cb_selectTrack_Lcom_otaliastudios_transcoder_common_TrackType_ == null)
				cb_selectTrack_Lcom_otaliastudios_transcoder_common_TrackType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SelectTrack_Lcom_otaliastudios_transcoder_common_TrackType_);
			return cb_selectTrack_Lcom_otaliastudios_transcoder_common_TrackType_;
		}

		static void n_SelectTrack_Lcom_otaliastudios_transcoder_common_TrackType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.IDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SelectTrack (p0);
		}
#pragma warning restore 0169

		IntPtr id_selectTrack_Lcom_otaliastudios_transcoder_common_TrackType_;
		public unsafe void SelectTrack (global::Com.Otaliastudios.Transcoder.Common.TrackType p0)
		{
			if (id_selectTrack_Lcom_otaliastudios_transcoder_common_TrackType_ == IntPtr.Zero)
				id_selectTrack_Lcom_otaliastudios_transcoder_common_TrackType_ = JNIEnv.GetMethodID (class_ref, "selectTrack", "(Lcom/otaliastudios/transcoder/common/TrackType;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_selectTrack_Lcom_otaliastudios_transcoder_common_TrackType_, __args);
		}

	}
}
