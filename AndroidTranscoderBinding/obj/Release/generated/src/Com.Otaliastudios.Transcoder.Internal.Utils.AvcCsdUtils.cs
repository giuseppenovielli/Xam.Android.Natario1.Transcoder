using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Internal.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='AvcCsdUtils']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/internal/utils/AvcCsdUtils", DoNotGenerateAcw=true)]
	public partial class AvcCsdUtils : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/internal/utils/AvcCsdUtils", typeof (AvcCsdUtils));

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

		protected AvcCsdUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='AvcCsdUtils']/method[@name='getSpsBuffer' and count(parameter)=1 and parameter[1][@type='android.media.MediaFormat']]"
		[Register ("getSpsBuffer", "(Landroid/media/MediaFormat;)Ljava/nio/ByteBuffer;", "")]
		public static unsafe global::Java.Nio.ByteBuffer GetSpsBuffer (global::Android.Media.MediaFormat format)
		{
			const string __id = "getSpsBuffer.(Landroid/media/MediaFormat;)Ljava/nio/ByteBuffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (format);
			}
		}

	}
}
