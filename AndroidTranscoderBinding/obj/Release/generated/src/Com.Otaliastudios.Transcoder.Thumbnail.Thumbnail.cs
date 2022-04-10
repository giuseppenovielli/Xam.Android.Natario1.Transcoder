using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Thumbnail {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.thumbnail']/class[@name='Thumbnail']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/thumbnail/Thumbnail", DoNotGenerateAcw=true)]
	public sealed partial class Thumbnail : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/thumbnail/Thumbnail", typeof (Thumbnail));

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

		internal Thumbnail (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::Android.Graphics.Bitmap Bitmap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.thumbnail']/class[@name='Thumbnail']/method[@name='getBitmap' and count(parameter)=0]"
			[Register ("getBitmap", "()Landroid/graphics/Bitmap;", "")]
			get {
				const string __id = "getBitmap.()Landroid/graphics/Bitmap;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe long PositionUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.thumbnail']/class[@name='Thumbnail']/method[@name='getPositionUs' and count(parameter)=0]"
			[Register ("getPositionUs", "()J", "")]
			get {
				const string __id = "getPositionUs.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Otaliastudios.Transcoder.Thumbnail.IThumbnailRequest Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.thumbnail']/class[@name='Thumbnail']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lcom/otaliastudios/transcoder/thumbnail/ThumbnailRequest;", "")]
			get {
				const string __id = "getRequest.()Lcom/otaliastudios/transcoder/thumbnail/ThumbnailRequest;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Thumbnail.IThumbnailRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
