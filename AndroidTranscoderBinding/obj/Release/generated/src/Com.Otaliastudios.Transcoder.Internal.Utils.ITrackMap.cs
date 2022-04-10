using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Internal.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='TrackMap.DefaultImpls']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/internal/utils/TrackMap$DefaultImpls", DoNotGenerateAcw=true)]
	public sealed partial class TrackMapDefaultImpls : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/internal/utils/TrackMap$DefaultImpls", typeof (TrackMapDefaultImpls));

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

		internal TrackMapDefaultImpls (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='TrackMap.DefaultImpls']/method[@name='audioOrNull' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.internal.utils.TrackMap&lt;T&gt;']]"
		[Register ("audioOrNull", "(Lcom/otaliastudios/transcoder/internal/utils/TrackMap;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object AudioOrNull (global::Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMap this_)
		{
			const string __id = "audioOrNull.(Lcom/otaliastudios/transcoder/internal/utils/TrackMap;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((this_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) this_).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (this_);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='TrackMap.DefaultImpls']/method[@name='getAudio' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.internal.utils.TrackMap&lt;T&gt;']]"
		[Register ("getAudio", "(Lcom/otaliastudios/transcoder/internal/utils/TrackMap;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetAudio (global::Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMap this_)
		{
			const string __id = "getAudio.(Lcom/otaliastudios/transcoder/internal/utils/TrackMap;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((this_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) this_).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (this_);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='TrackMap.DefaultImpls']/method[@name='getHasAudio' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.internal.utils.TrackMap&lt;T&gt;']]"
		[Register ("getHasAudio", "(Lcom/otaliastudios/transcoder/internal/utils/TrackMap;)Z", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe bool GetHasAudio (global::Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMap this_)
		{
			const string __id = "getHasAudio.(Lcom/otaliastudios/transcoder/internal/utils/TrackMap;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((this_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) this_).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (this_);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='TrackMap.DefaultImpls']/method[@name='getHasVideo' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.internal.utils.TrackMap&lt;T&gt;']]"
		[Register ("getHasVideo", "(Lcom/otaliastudios/transcoder/internal/utils/TrackMap;)Z", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe bool GetHasVideo (global::Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMap this_)
		{
			const string __id = "getHasVideo.(Lcom/otaliastudios/transcoder/internal/utils/TrackMap;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((this_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) this_).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (this_);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='TrackMap.DefaultImpls']/method[@name='getOrNull' and count(parameter)=2 and parameter[1][@type='com.otaliastudios.transcoder.internal.utils.TrackMap&lt;T&gt;'] and parameter[2][@type='com.otaliastudios.transcoder.common.TrackType']]"
		[Register ("getOrNull", "(Lcom/otaliastudios/transcoder/internal/utils/TrackMap;Lcom/otaliastudios/transcoder/common/TrackType;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetOrNull (global::Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMap this_, global::Com.Otaliastudios.Transcoder.Common.TrackType type)
		{
			const string __id = "getOrNull.(Lcom/otaliastudios/transcoder/internal/utils/TrackMap;Lcom/otaliastudios/transcoder/common/TrackType;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((this_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) this_).Handle);
				__args [1] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (this_);
				global::System.GC.KeepAlive (type);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='TrackMap.DefaultImpls']/method[@name='getSize' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.internal.utils.TrackMap&lt;T&gt;']]"
		[Register ("getSize", "(Lcom/otaliastudios/transcoder/internal/utils/TrackMap;)I", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe int GetSize (global::Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMap this_)
		{
			const string __id = "getSize.(Lcom/otaliastudios/transcoder/internal/utils/TrackMap;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((this_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) this_).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (this_);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='TrackMap.DefaultImpls']/method[@name='getVideo' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.internal.utils.TrackMap&lt;T&gt;']]"
		[Register ("getVideo", "(Lcom/otaliastudios/transcoder/internal/utils/TrackMap;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetVideo (global::Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMap this_)
		{
			const string __id = "getVideo.(Lcom/otaliastudios/transcoder/internal/utils/TrackMap;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((this_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) this_).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (this_);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='TrackMap.DefaultImpls']/method[@name='iterator' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.internal.utils.TrackMap&lt;T&gt;']]"
		[Register ("iterator", "(Lcom/otaliastudios/transcoder/internal/utils/TrackMap;)Ljava/util/Iterator;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Util.IIterator Iterator (global::Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMap this_)
		{
			const string __id = "iterator.(Lcom/otaliastudios/transcoder/internal/utils/TrackMap;)Ljava/util/Iterator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((this_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) this_).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (this_);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='TrackMap.DefaultImpls']/method[@name='videoOrNull' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.internal.utils.TrackMap&lt;T&gt;']]"
		[Register ("videoOrNull", "(Lcom/otaliastudios/transcoder/internal/utils/TrackMap;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object VideoOrNull (global::Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMap this_)
		{
			const string __id = "videoOrNull.(Lcom/otaliastudios/transcoder/internal/utils/TrackMap;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((this_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) this_).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (this_);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/interface[@name='TrackMap']"
	[Register ("com/otaliastudios/transcoder/internal/utils/TrackMap", "", "Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMapInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface ITrackMap : global::Java.Lang.IIterable, global::Kotlin.Jvm.Internal.Markers.IKMappedMarker {
		global::Java.Lang.Object Audio {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/interface[@name='TrackMap']/method[@name='getAudio' and count(parameter)=0]"
			[Register ("getAudio", "()Ljava/lang/Object;", "GetGetAudioHandler:Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMapInvoker, AndroidTranscoderBinding")]
			get; 
		}

		bool HasAudio {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/interface[@name='TrackMap']/method[@name='getHasAudio' and count(parameter)=0]"
			[Register ("getHasAudio", "()Z", "GetGetHasAudioHandler:Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMapInvoker, AndroidTranscoderBinding")]
			get; 
		}

		bool HasVideo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/interface[@name='TrackMap']/method[@name='getHasVideo' and count(parameter)=0]"
			[Register ("getHasVideo", "()Z", "GetGetHasVideoHandler:Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMapInvoker, AndroidTranscoderBinding")]
			get; 
		}

		int Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/interface[@name='TrackMap']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()I", "GetGetSizeHandler:Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMapInvoker, AndroidTranscoderBinding")]
			get; 
		}

		global::Java.Lang.Object Video {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/interface[@name='TrackMap']/method[@name='getVideo' and count(parameter)=0]"
			[Register ("getVideo", "()Ljava/lang/Object;", "GetGetVideoHandler:Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMapInvoker, AndroidTranscoderBinding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/interface[@name='TrackMap']/method[@name='audioOrNull' and count(parameter)=0]"
		[Register ("audioOrNull", "()Ljava/lang/Object;", "GetAudioOrNullHandler:Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMapInvoker, AndroidTranscoderBinding")]
		global::Java.Lang.Object AudioOrNull ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/interface[@name='TrackMap']/method[@name='get' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackType']]"
		[Register ("get", "(Lcom/otaliastudios/transcoder/common/TrackType;)Ljava/lang/Object;", "GetGet_Lcom_otaliastudios_transcoder_common_TrackType_Handler:Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMapInvoker, AndroidTranscoderBinding")]
		global::Java.Lang.Object Get (global::Com.Otaliastudios.Transcoder.Common.TrackType type);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/interface[@name='TrackMap']/method[@name='getOrNull' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackType']]"
		[Register ("getOrNull", "(Lcom/otaliastudios/transcoder/common/TrackType;)Ljava/lang/Object;", "GetGetOrNull_Lcom_otaliastudios_transcoder_common_TrackType_Handler:Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMapInvoker, AndroidTranscoderBinding")]
		global::Java.Lang.Object GetOrNull (global::Com.Otaliastudios.Transcoder.Common.TrackType type);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/interface[@name='TrackMap']/method[@name='has' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.common.TrackType']]"
		[Register ("has", "(Lcom/otaliastudios/transcoder/common/TrackType;)Z", "GetHas_Lcom_otaliastudios_transcoder_common_TrackType_Handler:Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMapInvoker, AndroidTranscoderBinding")]
		bool Has (global::Com.Otaliastudios.Transcoder.Common.TrackType type);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/interface[@name='TrackMap']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler:Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMapInvoker, AndroidTranscoderBinding")]
		global::Java.Util.IIterator Iterator ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/interface[@name='TrackMap']/method[@name='videoOrNull' and count(parameter)=0]"
		[Register ("videoOrNull", "()Ljava/lang/Object;", "GetVideoOrNullHandler:Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMapInvoker, AndroidTranscoderBinding")]
		global::Java.Lang.Object VideoOrNull ();

	}

	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/internal/utils/TrackMap", DoNotGenerateAcw=true)]
	internal partial class ITrackMapInvoker : global::Java.Lang.Object, ITrackMap {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/internal/utils/TrackMap", typeof (ITrackMapInvoker));

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

		public static ITrackMap GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITrackMap> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.otaliastudios.transcoder.internal.utils.TrackMap'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITrackMapInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAudio;
#pragma warning disable 0169
		static Delegate GetGetAudioHandler ()
		{
			if (cb_getAudio == null)
				cb_getAudio = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAudio);
			return cb_getAudio;
		}

		static IntPtr n_GetAudio (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Audio);
		}
#pragma warning restore 0169

		IntPtr id_getAudio;
		public unsafe global::Java.Lang.Object Audio {
			get {
				if (id_getAudio == IntPtr.Zero)
					id_getAudio = JNIEnv.GetMethodID (class_ref, "getAudio", "()Ljava/lang/Object;");
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAudio), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getHasAudio;
#pragma warning disable 0169
		static Delegate GetGetHasAudioHandler ()
		{
			if (cb_getHasAudio == null)
				cb_getHasAudio = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetHasAudio);
			return cb_getHasAudio;
		}

		static bool n_GetHasAudio (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasAudio;
		}
#pragma warning restore 0169

		IntPtr id_getHasAudio;
		public unsafe bool HasAudio {
			get {
				if (id_getHasAudio == IntPtr.Zero)
					id_getHasAudio = JNIEnv.GetMethodID (class_ref, "getHasAudio", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getHasAudio);
			}
		}

		static Delegate cb_getHasVideo;
#pragma warning disable 0169
		static Delegate GetGetHasVideoHandler ()
		{
			if (cb_getHasVideo == null)
				cb_getHasVideo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetHasVideo);
			return cb_getHasVideo;
		}

		static bool n_GetHasVideo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasVideo;
		}
#pragma warning restore 0169

		IntPtr id_getHasVideo;
		public unsafe bool HasVideo {
			get {
				if (id_getHasVideo == IntPtr.Zero)
					id_getHasVideo = JNIEnv.GetMethodID (class_ref, "getHasVideo", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getHasVideo);
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSize);
			return cb_getSize;
		}

		static int n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		IntPtr id_getSize;
		public unsafe int Size {
			get {
				if (id_getSize == IntPtr.Zero)
					id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSize);
			}
		}

		static Delegate cb_getVideo;
#pragma warning disable 0169
		static Delegate GetGetVideoHandler ()
		{
			if (cb_getVideo == null)
				cb_getVideo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetVideo);
			return cb_getVideo;
		}

		static IntPtr n_GetVideo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Video);
		}
#pragma warning restore 0169

		IntPtr id_getVideo;
		public unsafe global::Java.Lang.Object Video {
			get {
				if (id_getVideo == IntPtr.Zero)
					id_getVideo = JNIEnv.GetMethodID (class_ref, "getVideo", "()Ljava/lang/Object;");
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVideo), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_audioOrNull;
#pragma warning disable 0169
		static Delegate GetAudioOrNullHandler ()
		{
			if (cb_audioOrNull == null)
				cb_audioOrNull = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AudioOrNull);
			return cb_audioOrNull;
		}

		static IntPtr n_AudioOrNull (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AudioOrNull ());
		}
#pragma warning restore 0169

		IntPtr id_audioOrNull;
		public unsafe global::Java.Lang.Object AudioOrNull ()
		{
			if (id_audioOrNull == IntPtr.Zero)
				id_audioOrNull = JNIEnv.GetMethodID (class_ref, "audioOrNull", "()Ljava/lang/Object;");
			return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_audioOrNull), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_get_Lcom_otaliastudios_transcoder_common_TrackType_;
#pragma warning disable 0169
		static Delegate GetGet_Lcom_otaliastudios_transcoder_common_TrackType_Handler ()
		{
			if (cb_get_Lcom_otaliastudios_transcoder_common_TrackType_ == null)
				cb_get_Lcom_otaliastudios_transcoder_common_TrackType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Get_Lcom_otaliastudios_transcoder_common_TrackType_);
			return cb_get_Lcom_otaliastudios_transcoder_common_TrackType_;
		}

		static IntPtr n_Get_Lcom_otaliastudios_transcoder_common_TrackType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var type = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (native_type, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (type));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Lcom_otaliastudios_transcoder_common_TrackType_;
		public unsafe global::Java.Lang.Object Get (global::Com.Otaliastudios.Transcoder.Common.TrackType type)
		{
			if (id_get_Lcom_otaliastudios_transcoder_common_TrackType_ == IntPtr.Zero)
				id_get_Lcom_otaliastudios_transcoder_common_TrackType_ = JNIEnv.GetMethodID (class_ref, "get", "(Lcom/otaliastudios/transcoder/common/TrackType;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
			var __ret = (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Lcom_otaliastudios_transcoder_common_TrackType_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getOrNull_Lcom_otaliastudios_transcoder_common_TrackType_;
#pragma warning disable 0169
		static Delegate GetGetOrNull_Lcom_otaliastudios_transcoder_common_TrackType_Handler ()
		{
			if (cb_getOrNull_Lcom_otaliastudios_transcoder_common_TrackType_ == null)
				cb_getOrNull_Lcom_otaliastudios_transcoder_common_TrackType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetOrNull_Lcom_otaliastudios_transcoder_common_TrackType_);
			return cb_getOrNull_Lcom_otaliastudios_transcoder_common_TrackType_;
		}

		static IntPtr n_GetOrNull_Lcom_otaliastudios_transcoder_common_TrackType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var type = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (native_type, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetOrNull (type));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getOrNull_Lcom_otaliastudios_transcoder_common_TrackType_;
		public unsafe global::Java.Lang.Object GetOrNull (global::Com.Otaliastudios.Transcoder.Common.TrackType type)
		{
			if (id_getOrNull_Lcom_otaliastudios_transcoder_common_TrackType_ == IntPtr.Zero)
				id_getOrNull_Lcom_otaliastudios_transcoder_common_TrackType_ = JNIEnv.GetMethodID (class_ref, "getOrNull", "(Lcom/otaliastudios/transcoder/common/TrackType;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
			var __ret = (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOrNull_Lcom_otaliastudios_transcoder_common_TrackType_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_has_Lcom_otaliastudios_transcoder_common_TrackType_;
#pragma warning disable 0169
		static Delegate GetHas_Lcom_otaliastudios_transcoder_common_TrackType_Handler ()
		{
			if (cb_has_Lcom_otaliastudios_transcoder_common_TrackType_ == null)
				cb_has_Lcom_otaliastudios_transcoder_common_TrackType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Has_Lcom_otaliastudios_transcoder_common_TrackType_);
			return cb_has_Lcom_otaliastudios_transcoder_common_TrackType_;
		}

		static bool n_Has_Lcom_otaliastudios_transcoder_common_TrackType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var type = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (native_type, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Has (type);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_has_Lcom_otaliastudios_transcoder_common_TrackType_;
		public unsafe bool Has (global::Com.Otaliastudios.Transcoder.Common.TrackType type)
		{
			if (id_has_Lcom_otaliastudios_transcoder_common_TrackType_ == IntPtr.Zero)
				id_has_Lcom_otaliastudios_transcoder_common_TrackType_ = JNIEnv.GetMethodID (class_ref, "has", "(Lcom/otaliastudios/transcoder/common/TrackType;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_has_Lcom_otaliastudios_transcoder_common_TrackType_, __args);
			return __ret;
		}

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		IntPtr id_iterator;
		public unsafe global::Java.Util.IIterator Iterator ()
		{
			if (id_iterator == IntPtr.Zero)
				id_iterator = JNIEnv.GetMethodID (class_ref, "iterator", "()Ljava/util/Iterator;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_videoOrNull;
#pragma warning disable 0169
		static Delegate GetVideoOrNullHandler ()
		{
			if (cb_videoOrNull == null)
				cb_videoOrNull = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_VideoOrNull);
			return cb_videoOrNull;
		}

		static IntPtr n_VideoOrNull (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VideoOrNull ());
		}
#pragma warning restore 0169

		IntPtr id_videoOrNull;
		public unsafe global::Java.Lang.Object VideoOrNull ()
		{
			if (id_videoOrNull == IntPtr.Zero)
				id_videoOrNull = JNIEnv.GetMethodID (class_ref, "videoOrNull", "()Ljava/lang/Object;");
			return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_videoOrNull), JniHandleOwnership.TransferLocalRef);
		}

	}
}
