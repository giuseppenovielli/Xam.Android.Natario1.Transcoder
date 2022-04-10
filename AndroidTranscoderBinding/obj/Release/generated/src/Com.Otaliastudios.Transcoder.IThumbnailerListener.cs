using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='ThumbnailerListener.DefaultImpls']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/ThumbnailerListener$DefaultImpls", DoNotGenerateAcw=true)]
	public sealed partial class ThumbnailerListenerDefaultImpls : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/ThumbnailerListener$DefaultImpls", typeof (ThumbnailerListenerDefaultImpls));

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

		internal ThumbnailerListenerDefaultImpls (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='ThumbnailerListener.DefaultImpls']/method[@name='onThumbnailsCanceled' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.ThumbnailerListener']]"
		[Register ("onThumbnailsCanceled", "(Lcom/otaliastudios/transcoder/ThumbnailerListener;)V", "")]
		public static unsafe void OnThumbnailsCanceled (global::Com.Otaliastudios.Transcoder.IThumbnailerListener this_)
		{
			const string __id = "onThumbnailsCanceled.(Lcom/otaliastudios/transcoder/ThumbnailerListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((this_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) this_).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (this_);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='ThumbnailerListener.DefaultImpls']/method[@name='onThumbnailsCompleted' and count(parameter)=2 and parameter[1][@type='com.otaliastudios.transcoder.ThumbnailerListener'] and parameter[2][@type='java.util.List&lt;com.otaliastudios.transcoder.thumbnail.Thumbnail&gt;']]"
		[Register ("onThumbnailsCompleted", "(Lcom/otaliastudios/transcoder/ThumbnailerListener;Ljava/util/List;)V", "")]
		public static unsafe void OnThumbnailsCompleted (global::Com.Otaliastudios.Transcoder.IThumbnailerListener this_, global::System.Collections.Generic.IList<global::Com.Otaliastudios.Transcoder.Thumbnail.Thumbnail> thumbnails)
		{
			const string __id = "onThumbnailsCompleted.(Lcom/otaliastudios/transcoder/ThumbnailerListener;Ljava/util/List;)V";
			IntPtr native_thumbnails = global::Android.Runtime.JavaList<global::Com.Otaliastudios.Transcoder.Thumbnail.Thumbnail>.ToLocalJniHandle (thumbnails);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((this_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) this_).Handle);
				__args [1] = new JniArgumentValue (native_thumbnails);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_thumbnails);
				global::System.GC.KeepAlive (this_);
				global::System.GC.KeepAlive (thumbnails);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.otaliastudios.transcoder']/interface[@name='ThumbnailerListener']"
	[Register ("com/otaliastudios/transcoder/ThumbnailerListener", "", "Com.Otaliastudios.Transcoder.IThumbnailerListenerInvoker")]
	public partial interface IThumbnailerListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/interface[@name='ThumbnailerListener']/method[@name='onThumbnail' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.thumbnail.Thumbnail']]"
		[Register ("onThumbnail", "(Lcom/otaliastudios/transcoder/thumbnail/Thumbnail;)V", "GetOnThumbnail_Lcom_otaliastudios_transcoder_thumbnail_Thumbnail_Handler:Com.Otaliastudios.Transcoder.IThumbnailerListenerInvoker, AndroidTranscoderBinding")]
		void OnThumbnail (global::Com.Otaliastudios.Transcoder.Thumbnail.Thumbnail thumbnail);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/interface[@name='ThumbnailerListener']/method[@name='onThumbnailsCanceled' and count(parameter)=0]"
		[Register ("onThumbnailsCanceled", "()V", "GetOnThumbnailsCanceledHandler:Com.Otaliastudios.Transcoder.IThumbnailerListenerInvoker, AndroidTranscoderBinding")]
		void OnThumbnailsCanceled ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/interface[@name='ThumbnailerListener']/method[@name='onThumbnailsCompleted' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.otaliastudios.transcoder.thumbnail.Thumbnail&gt;']]"
		[Register ("onThumbnailsCompleted", "(Ljava/util/List;)V", "GetOnThumbnailsCompleted_Ljava_util_List_Handler:Com.Otaliastudios.Transcoder.IThumbnailerListenerInvoker, AndroidTranscoderBinding")]
		void OnThumbnailsCompleted (global::System.Collections.Generic.IList<global::Com.Otaliastudios.Transcoder.Thumbnail.Thumbnail> thumbnails);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/interface[@name='ThumbnailerListener']/method[@name='onThumbnailsFailed' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onThumbnailsFailed", "(Ljava/lang/Throwable;)V", "GetOnThumbnailsFailed_Ljava_lang_Throwable_Handler:Com.Otaliastudios.Transcoder.IThumbnailerListenerInvoker, AndroidTranscoderBinding")]
		void OnThumbnailsFailed (global::Java.Lang.Throwable exception);

	}

	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/ThumbnailerListener", DoNotGenerateAcw=true)]
	internal partial class IThumbnailerListenerInvoker : global::Java.Lang.Object, IThumbnailerListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/ThumbnailerListener", typeof (IThumbnailerListenerInvoker));

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

		public static IThumbnailerListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IThumbnailerListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.otaliastudios.transcoder.ThumbnailerListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IThumbnailerListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onThumbnail_Lcom_otaliastudios_transcoder_thumbnail_Thumbnail_;
#pragma warning disable 0169
		static Delegate GetOnThumbnail_Lcom_otaliastudios_transcoder_thumbnail_Thumbnail_Handler ()
		{
			if (cb_onThumbnail_Lcom_otaliastudios_transcoder_thumbnail_Thumbnail_ == null)
				cb_onThumbnail_Lcom_otaliastudios_transcoder_thumbnail_Thumbnail_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnThumbnail_Lcom_otaliastudios_transcoder_thumbnail_Thumbnail_);
			return cb_onThumbnail_Lcom_otaliastudios_transcoder_thumbnail_Thumbnail_;
		}

		static void n_OnThumbnail_Lcom_otaliastudios_transcoder_thumbnail_Thumbnail_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thumbnail)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.IThumbnailerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var thumbnail = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Thumbnail.Thumbnail> (native_thumbnail, JniHandleOwnership.DoNotTransfer);
			__this.OnThumbnail (thumbnail);
		}
#pragma warning restore 0169

		IntPtr id_onThumbnail_Lcom_otaliastudios_transcoder_thumbnail_Thumbnail_;
		public unsafe void OnThumbnail (global::Com.Otaliastudios.Transcoder.Thumbnail.Thumbnail thumbnail)
		{
			if (id_onThumbnail_Lcom_otaliastudios_transcoder_thumbnail_Thumbnail_ == IntPtr.Zero)
				id_onThumbnail_Lcom_otaliastudios_transcoder_thumbnail_Thumbnail_ = JNIEnv.GetMethodID (class_ref, "onThumbnail", "(Lcom/otaliastudios/transcoder/thumbnail/Thumbnail;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((thumbnail == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thumbnail).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onThumbnail_Lcom_otaliastudios_transcoder_thumbnail_Thumbnail_, __args);
		}

		static Delegate cb_onThumbnailsCanceled;
#pragma warning disable 0169
		static Delegate GetOnThumbnailsCanceledHandler ()
		{
			if (cb_onThumbnailsCanceled == null)
				cb_onThumbnailsCanceled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnThumbnailsCanceled);
			return cb_onThumbnailsCanceled;
		}

		static void n_OnThumbnailsCanceled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.IThumbnailerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnThumbnailsCanceled ();
		}
#pragma warning restore 0169

		IntPtr id_onThumbnailsCanceled;
		public unsafe void OnThumbnailsCanceled ()
		{
			if (id_onThumbnailsCanceled == IntPtr.Zero)
				id_onThumbnailsCanceled = JNIEnv.GetMethodID (class_ref, "onThumbnailsCanceled", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onThumbnailsCanceled);
		}

		static Delegate cb_onThumbnailsCompleted_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnThumbnailsCompleted_Ljava_util_List_Handler ()
		{
			if (cb_onThumbnailsCompleted_Ljava_util_List_ == null)
				cb_onThumbnailsCompleted_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnThumbnailsCompleted_Ljava_util_List_);
			return cb_onThumbnailsCompleted_Ljava_util_List_;
		}

		static void n_OnThumbnailsCompleted_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thumbnails)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.IThumbnailerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var thumbnails = global::Android.Runtime.JavaList<global::Com.Otaliastudios.Transcoder.Thumbnail.Thumbnail>.FromJniHandle (native_thumbnails, JniHandleOwnership.DoNotTransfer);
			__this.OnThumbnailsCompleted (thumbnails);
		}
#pragma warning restore 0169

		IntPtr id_onThumbnailsCompleted_Ljava_util_List_;
		public unsafe void OnThumbnailsCompleted (global::System.Collections.Generic.IList<global::Com.Otaliastudios.Transcoder.Thumbnail.Thumbnail> thumbnails)
		{
			if (id_onThumbnailsCompleted_Ljava_util_List_ == IntPtr.Zero)
				id_onThumbnailsCompleted_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onThumbnailsCompleted", "(Ljava/util/List;)V");
			IntPtr native_thumbnails = global::Android.Runtime.JavaList<global::Com.Otaliastudios.Transcoder.Thumbnail.Thumbnail>.ToLocalJniHandle (thumbnails);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_thumbnails);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onThumbnailsCompleted_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_thumbnails);
		}

		static Delegate cb_onThumbnailsFailed_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnThumbnailsFailed_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onThumbnailsFailed_Ljava_lang_Throwable_ == null)
				cb_onThumbnailsFailed_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnThumbnailsFailed_Ljava_lang_Throwable_);
			return cb_onThumbnailsFailed_Ljava_lang_Throwable_;
		}

		static void n_OnThumbnailsFailed_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_exception)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.IThumbnailerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var exception = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_exception, JniHandleOwnership.DoNotTransfer);
			__this.OnThumbnailsFailed (exception);
		}
#pragma warning restore 0169

		IntPtr id_onThumbnailsFailed_Ljava_lang_Throwable_;
		public unsafe void OnThumbnailsFailed (global::Java.Lang.Throwable exception)
		{
			if (id_onThumbnailsFailed_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onThumbnailsFailed_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onThumbnailsFailed", "(Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onThumbnailsFailed_Ljava_lang_Throwable_, __args);
		}

	}

	// event args for com.otaliastudios.transcoder.ThumbnailerListener.onThumbnail
	public partial class ThumbnailEventArgs : global::System.EventArgs {
		public ThumbnailEventArgs (global::Com.Otaliastudios.Transcoder.Thumbnail.Thumbnail thumbnail)
		{
			this.thumbnail = thumbnail;
		}

		global::Com.Otaliastudios.Transcoder.Thumbnail.Thumbnail thumbnail;

		public global::Com.Otaliastudios.Transcoder.Thumbnail.Thumbnail Thumbnail {
			get { return thumbnail; }
		}

	}

	// event args for com.otaliastudios.transcoder.ThumbnailerListener.onThumbnailsCompleted
	public partial class ThumbnailsCompletedEventArgs : global::System.EventArgs {
		public ThumbnailsCompletedEventArgs (global::System.Collections.Generic.IList<global::Com.Otaliastudios.Transcoder.Thumbnail.Thumbnail> thumbnails)
		{
			this.thumbnails = thumbnails;
		}

		global::System.Collections.Generic.IList<global::Com.Otaliastudios.Transcoder.Thumbnail.Thumbnail> thumbnails;

		public global::System.Collections.Generic.IList<global::Com.Otaliastudios.Transcoder.Thumbnail.Thumbnail> Thumbnails {
			get { return thumbnails; }
		}

	}

	// event args for com.otaliastudios.transcoder.ThumbnailerListener.onThumbnailsFailed
	public partial class ThumbnailsFailedEventArgs : global::System.EventArgs {
		public ThumbnailsFailedEventArgs (global::Java.Lang.Throwable exception)
		{
			this.exception = exception;
		}

		global::Java.Lang.Throwable exception;

		public global::Java.Lang.Throwable Exception {
			get { return exception; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/otaliastudios/transcoder/ThumbnailerListenerImplementor")]
	internal sealed partial class IThumbnailerListenerImplementor : global::Java.Lang.Object, IThumbnailerListener {

		object sender;

		public IThumbnailerListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/otaliastudios/transcoder/ThumbnailerListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<ThumbnailEventArgs> OnThumbnailHandler;
		#pragma warning restore 0649

		public void OnThumbnail (global::Com.Otaliastudios.Transcoder.Thumbnail.Thumbnail thumbnail)
		{
			var __h = OnThumbnailHandler;
			if (__h != null)
				__h (sender, new ThumbnailEventArgs (thumbnail));
		}

		#pragma warning disable 0649
		public EventHandler OnThumbnailsCanceledHandler;
		#pragma warning restore 0649

		public void OnThumbnailsCanceled ()
		{
			var __h = OnThumbnailsCanceledHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler<ThumbnailsCompletedEventArgs> OnThumbnailsCompletedHandler;
		#pragma warning restore 0649

		public void OnThumbnailsCompleted (global::System.Collections.Generic.IList<global::Com.Otaliastudios.Transcoder.Thumbnail.Thumbnail> thumbnails)
		{
			var __h = OnThumbnailsCompletedHandler;
			if (__h != null)
				__h (sender, new ThumbnailsCompletedEventArgs (thumbnails));
		}

		#pragma warning disable 0649
		public EventHandler<ThumbnailsFailedEventArgs> OnThumbnailsFailedHandler;
		#pragma warning restore 0649

		public void OnThumbnailsFailed (global::Java.Lang.Throwable exception)
		{
			var __h = OnThumbnailsFailedHandler;
			if (__h != null)
				__h (sender, new ThumbnailsFailedEventArgs (exception));
		}

		internal static bool __IsEmpty (IThumbnailerListenerImplementor value)
		{
			return value.OnThumbnailHandler == null && value.OnThumbnailsCanceledHandler == null && value.OnThumbnailsCompletedHandler == null && value.OnThumbnailsFailedHandler == null;
		}

	}
}
