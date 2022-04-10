using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Internal.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='TrackMapKt']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/internal/utils/TrackMapKt", DoNotGenerateAcw=true)]
	public sealed partial class TrackMapKt : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/internal/utils/TrackMapKt", typeof (TrackMapKt));

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

		internal TrackMapKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='TrackMapKt']/method[@name='mutableTrackMapOf' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("mutableTrackMapOf", "(Ljava/lang/Object;)Lcom/otaliastudios/transcoder/internal/utils/MutableTrackMap;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Otaliastudios.Transcoder.Internal.Utils.IMutableTrackMap MutableTrackMapOf (global::Java.Lang.Object @default)
		{
			const string __id = "mutableTrackMapOf.(Ljava/lang/Object;)Lcom/otaliastudios/transcoder/internal/utils/MutableTrackMap;";
			IntPtr native__default = JNIEnv.ToLocalJniHandle (@default);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__default);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.IMutableTrackMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__default);
				global::System.GC.KeepAlive (@default);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='TrackMapKt']/method[@name='mutableTrackMapOf' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='T']]"
		[Register ("mutableTrackMapOf", "(Ljava/lang/Object;Ljava/lang/Object;)Lcom/otaliastudios/transcoder/internal/utils/MutableTrackMap;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Otaliastudios.Transcoder.Internal.Utils.IMutableTrackMap MutableTrackMapOf (global::Java.Lang.Object video, global::Java.Lang.Object audio)
		{
			const string __id = "mutableTrackMapOf.(Ljava/lang/Object;Ljava/lang/Object;)Lcom/otaliastudios/transcoder/internal/utils/MutableTrackMap;";
			IntPtr native_video = JNIEnv.ToLocalJniHandle (video);
			IntPtr native_audio = JNIEnv.ToLocalJniHandle (audio);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_video);
				__args [1] = new JniArgumentValue (native_audio);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.IMutableTrackMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_video);
				JNIEnv.DeleteLocalRef (native_audio);
				global::System.GC.KeepAlive (video);
				global::System.GC.KeepAlive (audio);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='TrackMapKt']/method[@name='trackMapOf' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("trackMapOf", "(Ljava/lang/Object;)Lcom/otaliastudios/transcoder/internal/utils/TrackMap;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMap TrackMapOf (global::Java.Lang.Object @default)
		{
			const string __id = "trackMapOf.(Ljava/lang/Object;)Lcom/otaliastudios/transcoder/internal/utils/TrackMap;";
			IntPtr native__default = JNIEnv.ToLocalJniHandle (@default);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__default);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__default);
				global::System.GC.KeepAlive (@default);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='TrackMapKt']/method[@name='trackMapOf' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='T']]"
		[Register ("trackMapOf", "(Ljava/lang/Object;Ljava/lang/Object;)Lcom/otaliastudios/transcoder/internal/utils/TrackMap;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMap TrackMapOf (global::Java.Lang.Object video, global::Java.Lang.Object audio)
		{
			const string __id = "trackMapOf.(Ljava/lang/Object;Ljava/lang/Object;)Lcom/otaliastudios/transcoder/internal/utils/TrackMap;";
			IntPtr native_video = JNIEnv.ToLocalJniHandle (video);
			IntPtr native_audio = JNIEnv.ToLocalJniHandle (audio);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_video);
				__args [1] = new JniArgumentValue (native_audio);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.ITrackMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_video);
				JNIEnv.DeleteLocalRef (native_audio);
				global::System.GC.KeepAlive (video);
				global::System.GC.KeepAlive (audio);
			}
		}

	}
}
