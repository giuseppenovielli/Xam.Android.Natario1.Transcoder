using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.otaliastudios.transcoder']/interface[@name='TranscoderListener']"
	[Register ("com/otaliastudios/transcoder/TranscoderListener", "", "Com.Otaliastudios.Transcoder.ITranscoderListenerInvoker")]
	public partial interface ITranscoderListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/interface[@name='TranscoderListener']/method[@name='onTranscodeCanceled' and count(parameter)=0]"
		[Register ("onTranscodeCanceled", "()V", "GetOnTranscodeCanceledHandler:Com.Otaliastudios.Transcoder.ITranscoderListenerInvoker, AndroidTranscoderBinding")]
		void OnTranscodeCanceled ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/interface[@name='TranscoderListener']/method[@name='onTranscodeCompleted' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onTranscodeCompleted", "(I)V", "GetOnTranscodeCompleted_IHandler:Com.Otaliastudios.Transcoder.ITranscoderListenerInvoker, AndroidTranscoderBinding")]
		void OnTranscodeCompleted (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/interface[@name='TranscoderListener']/method[@name='onTranscodeFailed' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onTranscodeFailed", "(Ljava/lang/Throwable;)V", "GetOnTranscodeFailed_Ljava_lang_Throwable_Handler:Com.Otaliastudios.Transcoder.ITranscoderListenerInvoker, AndroidTranscoderBinding")]
		void OnTranscodeFailed (global::Java.Lang.Throwable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/interface[@name='TranscoderListener']/method[@name='onTranscodeProgress' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("onTranscodeProgress", "(D)V", "GetOnTranscodeProgress_DHandler:Com.Otaliastudios.Transcoder.ITranscoderListenerInvoker, AndroidTranscoderBinding")]
		void OnTranscodeProgress (double p0);

	}

	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/TranscoderListener", DoNotGenerateAcw=true)]
	internal partial class ITranscoderListenerInvoker : global::Java.Lang.Object, ITranscoderListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/TranscoderListener", typeof (ITranscoderListenerInvoker));

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

		public static ITranscoderListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITranscoderListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.otaliastudios.transcoder.TranscoderListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITranscoderListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onTranscodeCanceled;
#pragma warning disable 0169
		static Delegate GetOnTranscodeCanceledHandler ()
		{
			if (cb_onTranscodeCanceled == null)
				cb_onTranscodeCanceled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnTranscodeCanceled);
			return cb_onTranscodeCanceled;
		}

		static void n_OnTranscodeCanceled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.ITranscoderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTranscodeCanceled ();
		}
#pragma warning restore 0169

		IntPtr id_onTranscodeCanceled;
		public unsafe void OnTranscodeCanceled ()
		{
			if (id_onTranscodeCanceled == IntPtr.Zero)
				id_onTranscodeCanceled = JNIEnv.GetMethodID (class_ref, "onTranscodeCanceled", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTranscodeCanceled);
		}

		static Delegate cb_onTranscodeCompleted_I;
#pragma warning disable 0169
		static Delegate GetOnTranscodeCompleted_IHandler ()
		{
			if (cb_onTranscodeCompleted_I == null)
				cb_onTranscodeCompleted_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnTranscodeCompleted_I);
			return cb_onTranscodeCompleted_I;
		}

		static void n_OnTranscodeCompleted_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.ITranscoderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTranscodeCompleted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onTranscodeCompleted_I;
		public unsafe void OnTranscodeCompleted (int p0)
		{
			if (id_onTranscodeCompleted_I == IntPtr.Zero)
				id_onTranscodeCompleted_I = JNIEnv.GetMethodID (class_ref, "onTranscodeCompleted", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTranscodeCompleted_I, __args);
		}

		static Delegate cb_onTranscodeFailed_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnTranscodeFailed_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onTranscodeFailed_Ljava_lang_Throwable_ == null)
				cb_onTranscodeFailed_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnTranscodeFailed_Ljava_lang_Throwable_);
			return cb_onTranscodeFailed_Ljava_lang_Throwable_;
		}

		static void n_OnTranscodeFailed_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.ITranscoderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnTranscodeFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onTranscodeFailed_Ljava_lang_Throwable_;
		public unsafe void OnTranscodeFailed (global::Java.Lang.Throwable p0)
		{
			if (id_onTranscodeFailed_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onTranscodeFailed_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onTranscodeFailed", "(Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTranscodeFailed_Ljava_lang_Throwable_, __args);
		}

		static Delegate cb_onTranscodeProgress_D;
#pragma warning disable 0169
		static Delegate GetOnTranscodeProgress_DHandler ()
		{
			if (cb_onTranscodeProgress_D == null)
				cb_onTranscodeProgress_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_V) n_OnTranscodeProgress_D);
			return cb_onTranscodeProgress_D;
		}

		static void n_OnTranscodeProgress_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.ITranscoderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTranscodeProgress (p0);
		}
#pragma warning restore 0169

		IntPtr id_onTranscodeProgress_D;
		public unsafe void OnTranscodeProgress (double p0)
		{
			if (id_onTranscodeProgress_D == IntPtr.Zero)
				id_onTranscodeProgress_D = JNIEnv.GetMethodID (class_ref, "onTranscodeProgress", "(D)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTranscodeProgress_D, __args);
		}

	}

	// event args for com.otaliastudios.transcoder.TranscoderListener.onTranscodeCompleted
	public partial class TranscodeCompletedEventArgs : global::System.EventArgs {
		public TranscodeCompletedEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;

		public int P0 {
			get { return p0; }
		}

	}

	// event args for com.otaliastudios.transcoder.TranscoderListener.onTranscodeFailed
	public partial class TranscodeFailedEventArgs : global::System.EventArgs {
		public TranscodeFailedEventArgs (global::Java.Lang.Throwable p0)
		{
			this.p0 = p0;
		}

		global::Java.Lang.Throwable p0;

		public global::Java.Lang.Throwable P0 {
			get { return p0; }
		}

	}

	// event args for com.otaliastudios.transcoder.TranscoderListener.onTranscodeProgress
	public partial class TranscodeProgressEventArgs : global::System.EventArgs {
		public TranscodeProgressEventArgs (double p0)
		{
			this.p0 = p0;
		}

		double p0;

		public double P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/otaliastudios/transcoder/TranscoderListenerImplementor")]
	internal sealed partial class ITranscoderListenerImplementor : global::Java.Lang.Object, ITranscoderListener {

		object sender;

		public ITranscoderListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/otaliastudios/transcoder/TranscoderListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler OnTranscodeCanceledHandler;
		#pragma warning restore 0649

		public void OnTranscodeCanceled ()
		{
			var __h = OnTranscodeCanceledHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler<TranscodeCompletedEventArgs> OnTranscodeCompletedHandler;
		#pragma warning restore 0649

		public void OnTranscodeCompleted (int p0)
		{
			var __h = OnTranscodeCompletedHandler;
			if (__h != null)
				__h (sender, new TranscodeCompletedEventArgs (p0));
		}

		#pragma warning disable 0649
		public EventHandler<TranscodeFailedEventArgs> OnTranscodeFailedHandler;
		#pragma warning restore 0649

		public void OnTranscodeFailed (global::Java.Lang.Throwable p0)
		{
			var __h = OnTranscodeFailedHandler;
			if (__h != null)
				__h (sender, new TranscodeFailedEventArgs (p0));
		}

		#pragma warning disable 0649
		public EventHandler<TranscodeProgressEventArgs> OnTranscodeProgressHandler;
		#pragma warning restore 0649

		public void OnTranscodeProgress (double p0)
		{
			var __h = OnTranscodeProgressHandler;
			if (__h != null)
				__h (sender, new TranscodeProgressEventArgs (p0));
		}

		internal static bool __IsEmpty (ITranscoderListenerImplementor value)
		{
			return value.OnTranscodeCanceledHandler == null && value.OnTranscodeCompletedHandler == null && value.OnTranscodeFailedHandler == null && value.OnTranscodeProgressHandler == null;
		}

	}
}
