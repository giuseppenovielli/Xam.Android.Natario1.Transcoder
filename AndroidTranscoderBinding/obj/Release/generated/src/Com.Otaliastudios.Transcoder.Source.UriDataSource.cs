using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Source {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='UriDataSource']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/source/UriDataSource", DoNotGenerateAcw=true)]
	public partial class UriDataSource : global::Com.Otaliastudios.Transcoder.Source.DefaultDataSource {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/source/UriDataSource", typeof (UriDataSource));

		internal static new IntPtr class_ref {
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

		protected UriDataSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='UriDataSource']/constructor[@name='UriDataSource' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/net/Uri;)V", "")]
		public unsafe UriDataSource (global::Android.Content.Context context, global::Android.Net.Uri uri) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/net/Uri;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (uri);
			}
		}

		static Delegate cb_initializeExtractor_Landroid_media_MediaExtractor_;
#pragma warning disable 0169
		static Delegate GetInitializeExtractor_Landroid_media_MediaExtractor_Handler ()
		{
			if (cb_initializeExtractor_Landroid_media_MediaExtractor_ == null)
				cb_initializeExtractor_Landroid_media_MediaExtractor_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_InitializeExtractor_Landroid_media_MediaExtractor_);
			return cb_initializeExtractor_Landroid_media_MediaExtractor_;
		}

		static void n_InitializeExtractor_Landroid_media_MediaExtractor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_extractor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.UriDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var extractor = global::Java.Lang.Object.GetObject<global::Android.Media.MediaExtractor> (native_extractor, JniHandleOwnership.DoNotTransfer);
			__this.InitializeExtractor (extractor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='UriDataSource']/method[@name='initializeExtractor' and count(parameter)=1 and parameter[1][@type='android.media.MediaExtractor']]"
		[Register ("initializeExtractor", "(Landroid/media/MediaExtractor;)V", "GetInitializeExtractor_Landroid_media_MediaExtractor_Handler")]
		protected override unsafe void InitializeExtractor (global::Android.Media.MediaExtractor extractor)
		{
			const string __id = "initializeExtractor.(Landroid/media/MediaExtractor;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((extractor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) extractor).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (extractor);
			}
		}

		static Delegate cb_initializeRetriever_Landroid_media_MediaMetadataRetriever_;
#pragma warning disable 0169
		static Delegate GetInitializeRetriever_Landroid_media_MediaMetadataRetriever_Handler ()
		{
			if (cb_initializeRetriever_Landroid_media_MediaMetadataRetriever_ == null)
				cb_initializeRetriever_Landroid_media_MediaMetadataRetriever_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_InitializeRetriever_Landroid_media_MediaMetadataRetriever_);
			return cb_initializeRetriever_Landroid_media_MediaMetadataRetriever_;
		}

		static void n_InitializeRetriever_Landroid_media_MediaMetadataRetriever_ (IntPtr jnienv, IntPtr native__this, IntPtr native_retriever)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Source.UriDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var retriever = global::Java.Lang.Object.GetObject<global::Android.Media.MediaMetadataRetriever> (native_retriever, JniHandleOwnership.DoNotTransfer);
			__this.InitializeRetriever (retriever);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='UriDataSource']/method[@name='initializeRetriever' and count(parameter)=1 and parameter[1][@type='android.media.MediaMetadataRetriever']]"
		[Register ("initializeRetriever", "(Landroid/media/MediaMetadataRetriever;)V", "GetInitializeRetriever_Landroid_media_MediaMetadataRetriever_Handler")]
		protected override unsafe void InitializeRetriever (global::Android.Media.MediaMetadataRetriever retriever)
		{
			const string __id = "initializeRetriever.(Landroid/media/MediaMetadataRetriever;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((retriever == null) ? IntPtr.Zero : ((global::Java.Lang.Object) retriever).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (retriever);
			}
		}

	}
}
