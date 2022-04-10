using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Thumbnail {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.thumbnail']/class[@name='CoverThumbnailRequest']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/thumbnail/CoverThumbnailRequest", DoNotGenerateAcw=true)]
	public sealed partial class CoverThumbnailRequest : global::Java.Lang.Object, global::Com.Otaliastudios.Transcoder.Thumbnail.IThumbnailRequest {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/thumbnail/CoverThumbnailRequest", typeof (CoverThumbnailRequest));

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

		internal CoverThumbnailRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.thumbnail']/class[@name='CoverThumbnailRequest']/constructor[@name='CoverThumbnailRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CoverThumbnailRequest () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.thumbnail']/class[@name='CoverThumbnailRequest']/method[@name='locate' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("locate", "(J)Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Java.Lang.Long> Locate (long durationUs)
		{
			const string __id = "locate.(J)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (durationUs);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Java.Lang.Long>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
