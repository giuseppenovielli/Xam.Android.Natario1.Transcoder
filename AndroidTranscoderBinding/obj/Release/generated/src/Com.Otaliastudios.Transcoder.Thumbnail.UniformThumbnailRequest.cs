using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Thumbnail {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.thumbnail']/class[@name='UniformThumbnailRequest']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/thumbnail/UniformThumbnailRequest", DoNotGenerateAcw=true)]
	public sealed partial class UniformThumbnailRequest : global::Java.Lang.Object, global::Com.Otaliastudios.Transcoder.Thumbnail.IThumbnailRequest {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/thumbnail/UniformThumbnailRequest", typeof (UniformThumbnailRequest));

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

		internal UniformThumbnailRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.thumbnail']/class[@name='UniformThumbnailRequest']/constructor[@name='UniformThumbnailRequest' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe UniformThumbnailRequest (int count) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (count);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.thumbnail']/class[@name='UniformThumbnailRequest']/method[@name='locate' and count(parameter)=1 and parameter[1][@type='long']]"
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