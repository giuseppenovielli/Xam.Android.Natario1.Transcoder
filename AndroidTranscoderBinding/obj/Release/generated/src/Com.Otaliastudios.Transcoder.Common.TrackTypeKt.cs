using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.common']/class[@name='TrackTypeKt']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/common/TrackTypeKt", DoNotGenerateAcw=true)]
	public sealed partial class TrackTypeKt : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/common/TrackTypeKt", typeof (TrackTypeKt));

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

		internal TrackTypeKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.common']/class[@name='TrackTypeKt']/method[@name='getTrackType' and count(parameter)=1 and parameter[1][@type='android.media.MediaFormat']]"
		[Register ("getTrackType", "(Landroid/media/MediaFormat;)Lcom/otaliastudios/transcoder/common/TrackType;", "")]
		public static unsafe global::Com.Otaliastudios.Transcoder.Common.TrackType GetTrackType (global::Android.Media.MediaFormat obj)
		{
			const string __id = "getTrackType.(Landroid/media/MediaFormat;)Lcom/otaliastudios/transcoder/common/TrackType;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.common']/class[@name='TrackTypeKt']/method[@name='getTrackTypeOrNull' and count(parameter)=1 and parameter[1][@type='android.media.MediaFormat']]"
		[Register ("getTrackTypeOrNull", "(Landroid/media/MediaFormat;)Lcom/otaliastudios/transcoder/common/TrackType;", "")]
		public static unsafe global::Com.Otaliastudios.Transcoder.Common.TrackType GetTrackTypeOrNull (global::Android.Media.MediaFormat obj)
		{
			const string __id = "getTrackTypeOrNull.(Landroid/media/MediaFormat;)Lcom/otaliastudios/transcoder/common/TrackType;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.TrackType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

	}
}
